using DinoAPI.Datas;
using DinoAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DinoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public UsersController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet("/users")]
        public IActionResult GetAll(string? startFirstName)
        {
            if (startFirstName != null)
                return Ok(
                    _db.Users.Where(c => c.FirstName!.StartsWith(startFirstName)).ToList()
                    );

            return Ok(_db.Users.ToList());
        }

        [HttpGet("/users/name/{lastName}")]
        public IActionResult GetByName(string lastName)
        {
            var user = _db.Users.FirstOrDefault(c => c.LastName == lastName);

            if (user == null) return NotFound(new
            {
                Message = "There is no User with this name."
            });

            return Ok(new
            {
                Message = "User found !",
                User = user
            });
        }

        [HttpGet("/users/{id}")]
        public IActionResult GetById(int id)
        {
            var user = _db.Users.FirstOrDefault(c => c.Id == id);

            if (user == null) return NotFound(new
            {
                Message = "There is no User with this id."
            });

            return Ok(new
            {
                Message = "User found !",
                User = user
            });
        }

        [HttpPost("/users")]
        public IActionResult Add([FromBody] User user)
        {
            _db.Users.Add(user);
            if (_db.SaveChanges() > 0) return Ok("User added.");
            return BadRequest("Something went wrong...");
        }

        [HttpPut("/users/{id}")]
        public IActionResult Update(int id, [FromBody] User user)
        {
            var userFromDb = _db.Users.Find(id);
            // on récupère l'objet de la BDD, il est TRACKé par EFCore donc les modifications effectuées dessus sont répercutées sur la BDD au moment du SaveChanges

            if (userFromDb == null) return NotFound(new
            {
                Message = "There is no User with this id."
            });

            // on vient vérifier si les champs on changé AVANT de les modifier pour optimiser
            if (userFromDb.LastName != user.LastName)
                userFromDb.LastName = user.LastName;
            if (userFromDb.FirstName != user.FirstName)
                userFromDb.FirstName = user.FirstName;
            if (userFromDb.Gender != user.Gender)
                userFromDb.Gender = user.Gender;
            if (userFromDb.BirthDate != user.BirthDate)
                userFromDb.BirthDate = user.BirthDate;
            if (userFromDb.Email != user.Email)
                userFromDb.Email = user.Email;
            if (userFromDb.PassWord != user.PassWord)
                userFromDb.PassWord = user.PassWord;
            if (userFromDb.IsAdmin != user.IsAdmin)
                userFromDb.IsAdmin = user.IsAdmin;

            if (_db.SaveChanges() == 0) return BadRequest("Something went wrong...");

            return Ok("User Updated !");
        }

        [HttpDelete("/users/{id}")]
        public IActionResult Remove(int id)
        {
            var user = _db.Users.Find(id);

            if (user == null) return NotFound(new
            {
                Message = "There is no User with this id."
            });

            _db.Users.Remove(user);

            if (_db.SaveChanges() == 0) return BadRequest("Something went wrong...");

            return Ok("User Deleted !");
        }
    }
}
