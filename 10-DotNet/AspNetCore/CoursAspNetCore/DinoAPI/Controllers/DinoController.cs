using AutoMapper;
using DinoAPI.DTOs;
using DinoAPI.Helpers;
using DinoAPI.Migrations;
using DinoAPI.Models;
using DinoAPI.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DinoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    //[EnableCors(PolicyName = "allConnections")]
    public class DinoController : ControllerBase
    {
        private readonly IRepository<Dinosaur> _dinoRepository;
        private readonly IMapper _mapper;

        public DinoController(IRepository<Dinosaur> dinoRepository,
                              IMapper mapper)
        {
            this._dinoRepository = dinoRepository;
            this._mapper = mapper;
        }

        [HttpGet("/dinosaurs")]
        [AllowAnonymous]
        public async Task<IActionResult> GetAll(string? startSpecies)
        {
            List<Dinosaur> dinos;
            if (startSpecies != null)
                dinos = (await _dinoRepository.GetAll(d => d.Species!.StartsWith(startSpecies))).ToList();
            else
                dinos = (await _dinoRepository.GetAll()).ToList();

            List<DinosaurDTO> dinosDTO = _mapper.Map<List<Dinosaur>, List<DinosaurDTO>>(dinos);

            return Ok(dinosDTO);
        }

        //[Authorize(Roles = "Admin")]
        //[Authorize(Policy = "AdminPolicy")]
        [HttpGet("/dinosaurs/name/{name}")]
        public async Task<IActionResult> GetByName(string name)
        {
            var dino = _mapper.Map<Dinosaur?, DinosaurDTO?>(await _dinoRepository.Get(d => d.Name == name));

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
            var dinoDTO = _mapper.Map<Dinosaur?, DinosaurDTO?>(await _dinoRepository.GetById(id));

            if (dinoDTO == null) return NotFound(new
            {
                Message = "There is no Dino with this id."
            });

            return Ok(new
            {
                Message = "Dino found !",
                Dino = dinoDTO
            });
        }

        [HttpPost("/dinosaurs")]
        public async Task<IActionResult> Add([FromBody] DinosaurDTO dinosaurDTO)
        {
            var dinosaur = _mapper.Map<DinosaurDTO, Dinosaur>(dinosaurDTO);
            if(await _dinoRepository.Add(dinosaur)) return Ok("Dino added.");
            return BadRequest("Something went wrong...");
        }

        [HttpPut("/dinosaurs/{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] DinosaurDTO dinosaurDTO)
        {
            var dinosaur = _mapper.Map<DinosaurDTO, Dinosaur>(dinosaurDTO);

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
