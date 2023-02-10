using DinoAPI.Datas;
using DinoAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DinoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DinoController : ControllerBase
    {
        private readonly FakeDB _fakeDB;
        public DinoController(FakeDB fakeDB)
        {
            _fakeDB= fakeDB;
        }

        [HttpGet("/dinosaurs")]
        public IActionResult GetAll()
        {
            return Ok(_fakeDB.GetAll());
        }

        [HttpGet("/dinosaurs/{id}")]
        public IActionResult GetById(int id)
        {
            var dino = _fakeDB.GetById(id);

            if (dino == null) return NotFound(new
            {
                Message= "There is no Dino with this id."
            });

            return Ok(new
            {
                Message= "Dino found !",
                Dino = dino
            });
        }

        [HttpPost("/dinosaurs")]
        public IActionResult Add([FromBody] Dinosaur dinosaur)
        {
            // on ajoutera la notion de modelstate ici
            if(_fakeDB.Add(dinosaur)) return Ok("Dino added.");
            return BadRequest("Something went wrong...");
        }

        [HttpPut("/dinosaurs/{id}")]
        public IActionResult Update(int id, [FromBody] Dinosaur dinosaur)
        {
            var dino = _fakeDB.GetById(id);

            if (dino == null) return NotFound(new
            {
                Message = "There is no Dino with this id."
            });

            // on ajoutera la notion de modelstate ici

            if (!_fakeDB.Edit(id, dinosaur)) return BadRequest("Something went wrong...");

            return Ok("Dino Updated !");
        }

        [HttpDelete("/dinosaurs/{id}")]
        public IActionResult Remove(int id)
        {
            var dino = _fakeDB.GetById(id);

            if (dino == null) return NotFound(new
            {
                Message = "There is no Dino with this id."
            });

            if (!_fakeDB.Delete(id)) return BadRequest("Something went wrong...");

            return Ok("Dino Deleted !");
        }
    }
}
