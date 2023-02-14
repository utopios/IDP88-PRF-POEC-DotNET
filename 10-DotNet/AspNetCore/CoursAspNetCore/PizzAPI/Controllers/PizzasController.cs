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
        public IActionResult Menu()
        {
            return Ok(_dbContext.Pizzas.Include(p => p.Ingredients ).ToList());
        }

        [HttpPost("pizza")]
        public IActionResult AddPizza([FromBody] Pizza pizza)
        {
            _dbContext.Pizzas.Add(pizza);

            if (_dbContext.SaveChanges() >= 1)
                return Ok("Pizza added");

            return BadRequest("Something went wrong");
        }

        [HttpPost("pizza/add-topping/{pizzaId}")]
        public IActionResult AddTopping(int pizzaId, [FromBody] Ingredient ingredient)
        {
            if (_dbContext.Pizzas.Find(pizzaId) == null)
                return BadRequest("Pizza not found");

            ingredient.PizzaId = pizzaId;
            _dbContext.Ingredients.Add(ingredient);

            if (_dbContext.SaveChanges() >= 1)
                return Ok("Topping added");

            return BadRequest("Something went wrong");
        }

        [HttpDelete("pizza/remove-topping/{pizzaId}/{toppingId}")]
        public IActionResult RemoveTopping(int pizzaId, int toppingId)
        {
            if (_dbContext.Pizzas.Find(pizzaId) == null)
                return BadRequest("Pizza not found");

            var ing = _dbContext.Ingredients.Find(toppingId);

            if (ing == null)
                return BadRequest("Topping not found");

            if (ing.PizzaId != pizzaId)
                return BadRequest("Topping is on another Pizza");

            _dbContext.Ingredients.Remove(ing);

            if (_dbContext.SaveChanges() == 1)
                return Ok("Topping removed");

            return BadRequest("Something went wrong");
        }

        [HttpPut("pizza/{id}")]
        public IActionResult UpdatePizza(int id, [FromBody] Pizza pizza)
        {
            var pizzaFromDb = _dbContext.Pizzas.Include(p=> p.Ingredients).FirstOrDefault(p => p.Id == id);

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

            if (_dbContext.SaveChanges() == 0) return BadRequest("Something went wrong...");

            return Ok("Pizza Updated !");
        }

        [HttpDelete("pizza/{id}")]
        public IActionResult RemovePizza(int id)
        {
            var pizz = _dbContext.Pizzas.Find(id);
            if ( pizz == null)
                return BadRequest("Pizza not found");

            _dbContext.Pizzas.Remove(pizz);

            if (_dbContext.SaveChanges() == 1)
                return Ok("Pizza removed");

            return BadRequest("Something went wrong");
        }

    }
}
