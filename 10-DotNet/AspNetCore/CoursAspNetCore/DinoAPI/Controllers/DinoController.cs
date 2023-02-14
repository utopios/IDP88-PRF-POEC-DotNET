using DinoAPI.Helpers;
using DinoAPI.Models;
using DinoAPI.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DinoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    //[EnableCors(PolicyName = "allConnections")]
    public class DinoController : ControllerBase
    {
        private readonly IRepository<Dinosaur> _dinoRepository;

        public DinoController(IRepository<Dinosaur> dinoRepository)
        {
            this._dinoRepository = dinoRepository;
        }

        [HttpGet("/dinosaurs")]
        [AllowAnonymous]
        public async Task<IActionResult> GetAll(string? startSpecies)
        {
            if (startSpecies != null) 
                return Ok(
                    await _dinoRepository.GetAll(d => d.Species!.StartsWith(startSpecies))
                    );

            return Ok(await _dinoRepository.GetAll());
        }

        //[Authorize(Roles = "Admin")]
        //[Authorize(Policy = "AdminPolicy")]
        [HttpGet("/dinosaurs/name/{name}")]
        public async Task<IActionResult> GetByName(string name)
        {
            var dino = await _dinoRepository.Get(d => d.Name == name);

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
        public async Task<IActionResult> GetById(int id)
        {
            var dino = await _dinoRepository.GetById(id);

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
        public async Task<IActionResult> Add([FromBody] Dinosaur dinosaur)
        {
            if(await _dinoRepository.Add(dinosaur)) return Ok("Dino added.");
            return BadRequest("Something went wrong...");
        }

        [HttpPut("/dinosaurs/{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] Dinosaur dinosaur)
        {
            var dinoFromDb = await _dinoRepository.GetById(id);

            if (dinoFromDb == null) return NotFound(new
            {
                Message = "There is no Dino with this id."
            });

            dinosaur.Id = id;

            if (!await _dinoRepository.Update(dinosaur)) return BadRequest("Something went wrong...");

            return Ok("Dino Updated !");
        }

        [HttpDelete("/dinosaurs/{id}")]
        [Authorize(Roles = Constants.RoleAdmin)]
        public async Task<IActionResult> Remove(int id)
        {
            var dino = _dinoRepository.GetById(id);

            if (dino == null) return NotFound(new
            {
                Message = "There is no Dino with this id."
            });

            if (!await _dinoRepository.Delete(id)) return BadRequest("Something went wrong...");

            return Ok("Dino Deleted !");
        }
    }
}
