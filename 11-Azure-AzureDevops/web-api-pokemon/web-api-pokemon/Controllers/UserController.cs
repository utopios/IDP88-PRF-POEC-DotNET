using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using web_api_pokemon.DTOs;
using web_api_pokemon.Services;
using web_api_pokemon.Services.Interfaces;
using web_api_pokemon.Tools;

namespace web_api_pokemon.Controllers;

[Route("user")]
[ApiController]
public class UserController : ControllerBase
{

    private ILogin _login;
    private readonly DataBaseContext _dbContext;

    public UserController(ILogin login, DataBaseContext dataBaseContext)
    {
        _login = login;
        _dbContext = dataBaseContext;
    }


    [HttpPost("login")]
    public IActionResult Login([FromForm] string name, [FromForm] string password)
    {
        string token = _login.Login(name, password);
        if (token != null)
        {
            return Ok(token);
        }
        return StatusCode(402);
    }

    [Authorize("user")]
    [HttpGet("{id}")]
    public async Task<IActionResult> Get(int id)
    {
        try
        {
            var u = _dbContext.Users.Include(u => u.Pokemons).ThenInclude(up => up.Pokemon).FirstOrDefault(u => u.Id == id);
            return Ok(u);
        }
        catch (Exception e)
        {
            return NotFound(new { Message = e.Message });
        }
    }
}