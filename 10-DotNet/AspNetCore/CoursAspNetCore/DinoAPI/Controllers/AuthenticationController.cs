using DinoAPI.Datas;
using DinoAPI.DTOs;
using DinoAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace DinoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[AllowAnonymous] // déjà présent par défaut => donne l'accès aux personnes non-authentifiées
    public class AuthenticationController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        private readonly string _securityKey = "clé super secrète";
        public AuthenticationController(ApplicationDbContext dbContext)
        {
            _db= dbContext;
        }

        [HttpPost("register")]
        public IActionResult Register([FromBody] User user)
        {
            if (_db.Users.FirstOrDefault(u => u.Email == user.Email) != null)
                return BadRequest("Email is already taken!");

            // chiffrage du mot de passe
            user.PassWord = EncryptPassword(user.PassWord);
            // isAdmin => false

            _db.Users.Add(user);

            if (_db.SaveChanges() > 0) return Ok("User regitered.");
            return BadRequest("Something went wrong...");
        }

        [HttpPost("login")]
        public IActionResult Login(LoginRequestDTO login)
        {
            // chiffrage du mot de passe
            login.PassWord = EncryptPassword(login.PassWord);

            var user = _db.Users.FirstOrDefault(u => u.Email == login.Email && u.PassWord == login.PassWord);

            if (user == null) return BadRequest("Invalid Authentication !");

            var role = user.IsAdmin ? "Admin" : "User";

            //JWT
            List<Claim> claims= new List<Claim>()
            {
                new Claim(ClaimTypes.Role, role),
                new Claim("EstUnDresseurDeDino", "true"),
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
            };

            SigningCredentials signingCredentials = new SigningCredentials(
                new SymmetricSecurityKey(Encoding.ASCII.GetBytes("clé très sécurisée: Denver le dernier dinosaur !")),
                SecurityAlgorithms.HmacSha256);

            JwtSecurityToken jwt = new JwtSecurityToken(
                issuer: "dinocorp",
                audience: "dinocorp",
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


        private string EncryptPassword(string? password)
        {
            if (string.IsNullOrEmpty(password)) return "";
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(password + _securityKey));
        }
        private string DecryptPassword(string? cryptedString)
        {
            if (string.IsNullOrEmpty(cryptedString)) return "";
            string decryptedString = Encoding.UTF8.GetString(Convert.FromBase64String(cryptedString));
            return decryptedString.Substring(0, decryptedString.Length - _securityKey!.Length);
        }
    }
}
