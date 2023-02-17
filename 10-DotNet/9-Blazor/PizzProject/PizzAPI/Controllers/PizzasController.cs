using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PizzAPI.Datas;
using PizzAPI.Helpers;
using PizzCore.Models;

namespace PizzAPI.Controllers
{
    [Route("api/pizzas")]
    [ApiController]
    //[Authorize(Roles = Constants.RoleAdmin)]
    public class PizzasController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;

        public PizzasController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        //[Authorize(Roles = Constants.RoleUser+","+Constants.RoleAdmin)]
        public async Task<IActionResult> Menu()
        {
            return Ok(await _dbContext.Pizzas.Include(p => p.Ingredients).ToListAsync());
        }

        [HttpPost]
        public async Task<IActionResult> AddPizza([FromBody] Pizza pizza)
        {
            await _dbContext.Pizzas.AddAsync(pizza);

            if (await _dbContext.SaveChangesAsync() >= 1)
                return Ok("Pizza added");

            return BadRequest("Something went wrong");
        }

        [HttpPost("add-topping/{pizzaId}")]
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

        [HttpDelete("remove-topping/{pizzaId}/{toppingId}")]
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

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdatePizza(int id, [FromBody] Pizza pizza)
        {
            var pizzaFromDb = await _dbContext.Pizzas.Include(p => p.Ingredients).FirstOrDefaultAsync(p => p.Id == id);

            if (pizzaFromDb == null) return NotFound(new
            {
                Message = "There is no User with this id."
            });

            if (pizzaFromDb.Name != pizza.Name)
                pizzaFromDb.Name = pizza.Name;
            if (pizzaFromDb.Price != pizza.Price)
                pizzaFromDb.Price = pizza.Price;
            if (pizzaFromDb.ImageLink != pizza.ImageLink)
                pizzaFromDb.ImageLink = pizza.ImageLink;

            // mettre à jour les ingrédients :
            if (pizza.Ingredients != null)
            {
                // gestion des ingrédients déjà existants en BDD
                foreach (var ingredientFromDb in pizzaFromDb.Ingredients!)
                {
                    var ingredientDejaExistant = pizza.Ingredients.FirstOrDefault(i => i.Name == ingredientFromDb.Name);
                    // l'ingrédient existe déjà donc pas de modification => on le retire des ingrédients à traiter
                    if (ingredientDejaExistant != null)
                    {
                        pizza.Ingredients.Remove(ingredientDejaExistant);
                        continue;
                    }
                    // l'ingrédient a été retiré de la pizza donc on le retire de la BDD
                    _dbContext.Ingredients.Remove(ingredientFromDb);
                }
                // ajout des nouveaux ingrédients (ceux qui restent dans pizza)
                foreach (var nouvelIngredient in pizza.Ingredients)
                {
                    await _dbContext.Ingredients.AddAsync(nouvelIngredient);
                }
            }
            else
            {
                // la nouvelle pizza n'a pas d'ingrédients => on supprime les ingrédients existants
                foreach (var ingredientFromDb in pizzaFromDb.Ingredients!)
                {
                    _dbContext.Ingredients.Remove(ingredientFromDb);
                }
            }

            if (await _dbContext.SaveChangesAsync() == 0) return BadRequest("Something went wrong...");

            return Ok("Pizza Updated !");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> RemovePizza(int id)
        {
            var pizz = await _dbContext.Pizzas.FindAsync(id);
            if (pizz == null)
                return BadRequest("Pizza not found");

            _dbContext.Pizzas.Remove(pizz);

            if (await _dbContext.SaveChangesAsync() == 1)
                return Ok("Pizza removed");

            return BadRequest("Something went wrong");
        }

    }
}
