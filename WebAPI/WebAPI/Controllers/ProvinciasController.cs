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
    [ApiController]
    [Route("api/[controller]")]
    public class ProvinciasController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IBienvenidosAPIRepo _repository;
        public ProvinciasController(IMapper mapper, IBienvenidosAPIRepo repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProvinciaLeerDTO>>> TraerTodasProvincias()
        {
            List<ProvinciaLeerDTO> provinciasLista = new List<ProvinciaLeerDTO>();
            var provinciaItems = _repository.TraerTodasProvincias();
            foreach (Provincia p in provinciaItems)
            {
                var pro = new ProvinciaLeerDTO();
                pro.Nombre = p.Nombre;
                pro.Id = p.Id;
                pro.Idpais = p.Idpais;
                pro.Pais = _repository.TraerPais(p.Idpais).Nombre;
                provinciasLista.Add(pro);

            }
            return Ok(provinciasLista);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<ProvinciaLeerDTO>>> TraerProvinciaIdPais(int id)
        {
            var provinciaItems = _repository.TraerProvinciaIdPais(id);
            return Ok(_mapper.Map<IEnumerable<ProvinciaLeerDTO>>(provinciaItems));
        }
    }
}
