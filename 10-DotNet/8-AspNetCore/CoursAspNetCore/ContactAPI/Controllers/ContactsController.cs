using ContactAPI.Data;
using ContactAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ContactAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public ContactsController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet("/contacts")]
        public IActionResult GetAll(string? startFirstName)
        {
            if (startFirstName != null) 
                return Ok(
                    _db.Contacts.Where(c => c.FirstName!.StartsWith(startFirstName)).ToList()
                    );

            return Ok(_db.Contacts.ToList());
        }

        [HttpGet("/contacts/name/{lastName}")]
        public IActionResult GetByName(string lastName)
        {
            var contact = _db.Contacts.FirstOrDefault(c => c.LastName == lastName);

            if (contact == null) return NotFound(new
            {
                Message = "There is no Contact with this name."
            });

            return Ok(new
            {
                Message = "Contact found !",
                Contact = contact
            });
        }

        [HttpGet("/contacts/{id}")]
        public IActionResult GetById(int id)
        {
            var contact = _db.Contacts.FirstOrDefault(c => c.Id == id);

            if (contact == null) return NotFound(new
            {
                Message = "There is no Contact with this id."
            });

            return Ok(new
            {
                Message = "Contact found !",
                Contact = contact
            });
        }

        [HttpPost("/contacts")]
        public IActionResult Add([FromBody] Contact contact)
        {
            _db.Contacts.Add(contact);
            if (_db.SaveChanges() > 0) return Ok("Contact added.");
            return BadRequest("Something went wrong...");
        }

        [HttpPut("/contacts/{id}")]
        public IActionResult Update(int id, [FromBody] Contact contact)
        {
            var contactFromDb = _db.Contacts.Find(id); 
            // on récupère l'objet de la BDD, il est TRACKé par EFCore donc les modifications effectuées dessus sont répercutées sur la BDD au moment du SaveChanges

            if (contactFromDb == null) return NotFound(new
            {
                Message = "There is no Contact with this id."
            });

            // on vient vérifier si les champs on changé AVANT de les modifier pour optimiser
            if (contactFromDb.LastName != contact.LastName)
                contactFromDb.LastName = contact.LastName;
            if (contactFromDb.FirstName != contact.FirstName)
                contactFromDb.FirstName = contact.FirstName;
            if (contactFromDb.Gender != contact.Gender)
                contactFromDb.Gender = contact.Gender;
            if (contactFromDb.BirthDate != contact.BirthDate)
                contactFromDb.BirthDate = contact.BirthDate;

            if (_db.SaveChanges() == 0) return BadRequest("Something went wrong...");

            return Ok("Contact Updated !");
        }

        [HttpDelete("/contacts/{id}")]
        public IActionResult Remove(int id)
        {
            var contact = _db.Contacts.Find(id);

            if (contact == null) return NotFound(new
            {
                Message = "There is no Contact with this id."
            });

            _db.Contacts.Remove(contact);

            if (_db.SaveChanges() == 0) return BadRequest("Something went wrong...");

            return Ok("Contact Deleted !");
        }
    }
}
