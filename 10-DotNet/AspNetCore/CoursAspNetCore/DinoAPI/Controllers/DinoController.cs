using DinoAPI.Datas;
using DinoAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DinoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    //[EnableCors(PolicyName = "allConnections")]
    public class DinoController : ControllerBase
    {
        private readonly FakeDB _fakeDB;
        public DinoController(FakeDB fakeDB)
        {
            _fakeDB= fakeDB;
        }

        [HttpGet("/dinosaurs")]
        [AllowAnonymous]
        public IActionResult GetAll(string? startSepecies)
        {
            if (startSepecies != null) return Ok(_fakeDB.GetAll(startSepecies));

            return Ok(_fakeDB.GetAll());
        }

        //[Authorize(Roles = "Admin")]
        //[Authorize(Policy = "AdminPolicy")]
        [HttpGet("/dinosaurs/name/{name}")]
        public IActionResult GetByName(string name)
        {
            var dino = _fakeDB.GetByName(name);

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

        [HttpGet("/dinosaurs/{id}")]
        public IActionResult GetById(int id)
        {
            var dino = _fakeDB.GetById(id);

            if (dino == null) return NotFound(new
            {
                Message = "There is no Dino with this id."
            });

            return Ok(new
            {
                Message = "Dino found !",
                Dino = dino
            });
        }

        [HttpPost("/dinosaurs")]
        public IActionResult Add([FromBody] Dinosaur dinosaur)
        {
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

            if (!_fakeDB.Edit(id, dinosaur)) return BadRequest("Something went wrong...");

            return Ok("Dino Updated !");
        }

        [HttpDelete("/dinosaurs/{id}")]
        [Authorize(Roles = "Admin")]
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
