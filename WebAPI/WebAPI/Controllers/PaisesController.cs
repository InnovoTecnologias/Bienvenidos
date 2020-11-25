using AutoMapper;
using BienvenidosWebAPI.Data;
using BienvenidosWebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.DTOs;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaisesController : ControllerBase
    {
        private readonly IBienvenidosAPIRepo _repository;
        private readonly IMapper _mapper;

        public PaisesController(IBienvenidosAPIRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        // GET: api/Paises
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PaisLeerDTO>>> Get()
        {
            var paisItems = _repository.TraerTodosPaises();
            return Ok(_mapper.Map<IEnumerable<PaisLeerDTO>>(paisItems));
        }

        [HttpGet("{id}", Name = "TraerPaisId")]
        public async Task<ActionResult<IEnumerable<PaisLeerDTO>>> TraerPaisId(int id)
        {
            var pais = _repository.TraerPais(id);
            if (pais == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<PaisLeerDTO>(pais));
        }

        [HttpPost]
        public async Task<ActionResult<PaisLeerDTO>> CrearPais(PaisCrearDTO pais)
        {
            var paisItem = _mapper.Map<Pais>(pais);
            _repository.CrearPais(paisItem);
            _repository.SaveChanges();
            var paisReadDto = _mapper.Map<PaisLeerDTO>(paisItem);



            return CreatedAtRoute(nameof(TraerPaisId), new { Id = paisReadDto.Id }, paisReadDto);
        }
    }
}
