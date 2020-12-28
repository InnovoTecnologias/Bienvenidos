using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BienvenidosWebAPI.Models;
using BienvenidosWebAPI.Data;
using AutoMapper;
using BienvenidosWebAPI.DTOs;

namespace BienvenidosWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CentrosController : ControllerBase
    {
        private readonly IBienvenidosAPIRepo _repository;
        private readonly IMapper _mapper;

        public CentrosController(IBienvenidosAPIRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        // GET: api/Centros
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CentroLeerDTO>>> Get()
        {
            _repository.CrearCentro(new Centro()
            {
                Nombre = "Hospital de Niños La Plata",
                Direccion = "Calle 14 entre 65 y 66",
                Validado = true,
                ValidadoFecha = DateTime.Now,
                ValidadoPor="admin",
                Idciudad=1
            });

            var commandItems = _repository.TraerTodosCentros();
            return Ok(_mapper.Map<IEnumerable<CentroLeerDTO>>(commandItems));
        }

        // GET: api/Centros/ciudad/id
        // Traer centro por id de ciudad
        [HttpGet("ciudad/{id}")]
        public async Task<ActionResult<IEnumerable<CentroLeerDTO>>> GetCentrosIdCiudad(int id)
        {
            return Ok(_mapper.Map<IEnumerable<CentroLeerDTO>>(_repository.TraerCentroIdCiudad(id)));
        }

        /*
        // GET: api/Centros/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Centro>> GetCentro(int id)
        {
            var centro = await _context.Centro.FindAsync(id);

            if (centro == null)
            {
                return NotFound();
            }

            return centro;
        }

        // PUT: api/Centros/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCentro(int id, Centro centro)
        {
            if (id != centro.Id)
            {
                return BadRequest();
            }

            _context.Entry(centro).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CentroExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Centros
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Centro>> PostCentro(Centro centro)
        {
            _context.Centro.Add(centro);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCentro", new { id = centro.Id }, centro);
        }

        // DELETE: api/Centros/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Centro>> DeleteCentro(int id)
        {
            var centro = await _context.Centro.FindAsync(id);
            if (centro == null)
            {
                return NotFound();
            }

            _context.Centro.Remove(centro);
            await _context.SaveChangesAsync();

            return centro;
        }

        private bool CentroExists(int id)
        {
            return _context.Centro.Any(e => e.Id == id);
        }
        */
    }
}
