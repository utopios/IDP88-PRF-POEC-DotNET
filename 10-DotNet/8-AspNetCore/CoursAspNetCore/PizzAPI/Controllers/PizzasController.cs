using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PizzAPI.Datas;
using PizzAPI.Helpers;
using PizzAPI.Models;

namespace PizzAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = Constants.RoleAdmin)]
    public class PizzasController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;

        public PizzasController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet("menu")]
        [Authorize(Roles = Constants.RoleUser+","+Constants.RoleAdmin)]
        public async Task<IActionResult> Menu()
        {
            return Ok(await _dbContext.Pizzas.Include(p => p.Ingredients ).ToListAsync());
        }

        [HttpPost("pizza")]
        public async Task<IActionResult> AddPizza([FromBody] Pizza pizza)
        {
            await _dbContext.Pizzas.AddAsync(pizza);

            if (await _dbContext.SaveChangesAsync() >= 1)
                return Ok("Pizza added");

            return BadRequest("Something went wrong");
        }

        [HttpPost("pizza/add-topping/{pizzaId}")]
        public async Task<IActionResult> AddTopping(int pizzaId, [FromBody] Ingredient ingredient)
        {
            if (await _dbContext.Pizzas.FindAsync(pizzaId) == null)
                return BadRequest("Pizza not found");

            ingredient.PizzaId = pizzaId;
            await _dbContext.Ingredients.AddAsync(ingredient);

            if (await _dbContext.SaveChangesAsync() >= 1)
                return Ok("Topping added");

            return BadRequest("Something went wrong");
        }

        [HttpDelete("pizza/remove-topping/{pizzaId}/{toppingId}")]
        public async Task<IActionResult> RemoveTopping(int pizzaId, int toppingId)
        {
            if (await _dbContext.Pizzas.FindAsync(pizzaId) == null)
                return BadRequest("Pizza not found");

            var ing = await _dbContext.Ingredients.FindAsync(toppingId);

            if (ing == null)
                return BadRequest("Topping not found");

            if (ing.PizzaId != pizzaId)
                return BadRequest("Topping is on another Pizza");

            _dbContext.Ingredients.Remove(ing);

            if (await _dbContext.SaveChangesAsync() == 1)
                return Ok("Topping removed");

            return BadRequest("Something went wrong");
        }

        [HttpPut("pizza/{id}")]
        public async Task<IActionResult> UpdatePizza(int id, [FromBody] Pizza pizza)
        {
            var pizzaFromDb = await _dbContext.Pizzas.Include(p=> p.Ingredients).FirstOrDefaultAsync(p => p.Id == id);

            if (pizzaFromDb == null) return NotFound(new
            {
                Message = "There is no User with this id."
            });

            if (pizzaFromDb.Nom != pizza.Nom)
                pizzaFromDb.Nom = pizza.Nom;
            if (pizzaFromDb.Description != pizza.Description)
                pizzaFromDb.Description= pizza.Description;
            if (pizzaFromDb.Prix != pizza.Prix)
                pizzaFromDb.Prix= pizza.Prix;
            if (pizzaFromDb.Statuts != pizza.Statuts)
                pizzaFromDb.Statuts= pizza.Statuts;

            if (await _dbContext.SaveChangesAsync() == 0) return BadRequest("Something went wrong...");

            return Ok("Pizza Updated !");
        }

        [HttpDelete("pizza/{id}")]
        public async Task<IActionResult> RemovePizza(int id)
        {
            var pizz = await _dbContext.Pizzas.FindAsync(id);
            if ( pizz == null)
                return BadRequest("Pizza not found");

            _dbContext.Pizzas.Remove(pizz);

            if (await _dbContext.SaveChangesAsync() == 1)
                return Ok("Pizza removed");

            return BadRequest("Something went wrong");
        }

    }
}
