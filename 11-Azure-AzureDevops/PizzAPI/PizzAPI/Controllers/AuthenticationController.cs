using PizzAPI.Datas;
using PizzAPI.DTOs;
using PizzAPI.Helpers;
using PizzCore.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace PizzAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        private readonly AppSettings _settings;
        private readonly string _securityKey = "clé super secrète";
        public AuthenticationController(ApplicationDbContext dbContext,
            IOptions<AppSettings> appSettings)
        {
            _db= dbContext;
            _settings = appSettings.Value;
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Register([FromBody] User user)
        {
            if (await _db.Users.FirstOrDefaultAsync(u => u.Email == user.Email) != null)
                return BadRequest("Email is already taken!");

            user.PassWord = EncryptPassword(user.PassWord);
            // isAdmin => false

            await _db.Users.AddAsync(user);

            if (await _db.SaveChangesAsync() > 0) return Ok("User regitered.");
            return BadRequest("Something went wrong...");
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequestDTO login)
        {
            login.PassWord = EncryptPassword(login.PassWord);

            var user = await _db.Users.FirstOrDefaultAsync(u => u.Email == login.Email && u.PassWord == login.PassWord);

            if (user == null) return BadRequest("Invalid Authentication !");

            var role = user.IsAdmin ? "Admin" : "User";

            //JWT
            List<Claim> claims= new List<Claim>()
            {
                new Claim(ClaimTypes.Role, role),
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
            };

            SigningCredentials signingCredentials = new SigningCredentials(
                new SymmetricSecurityKey(Encoding.ASCII.GetBytes(_settings.SecretKey!)),
                SecurityAlgorithms.HmacSha256);

            JwtSecurityToken jwt = new JwtSecurityToken(
                issuer: _settings.ValidIssuer,
                audience: _settings.ValidAudience,
                claims: claims,
                signingCredentials: signingCredentials,
                expires: DateTime.Now.AddDays(7)
                );

            var token = new JwtSecurityTokenHandler().WriteToken(jwt);

            return Ok(new
            {
                Token = token,
                Message= "Valid Authentication !",
                User= user
            });
        }

        [NonAction]
        private string EncryptPassword(string? password)
        {
            if (string.IsNullOrEmpty(password)) return "";
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(password + _securityKey));
        }

        [NonAction]
        private string DecryptPassword(string? cryptedString)
        {
            if (string.IsNullOrEmpty(cryptedString)) return "";
            string decryptedString = Encoding.UTF8.GetString(Convert.FromBase64String(cryptedString));
            return decryptedString.Substring(0, decryptedString.Length - _securityKey!.Length);
        }
    }
}
