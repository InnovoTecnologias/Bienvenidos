using AutoMapper;
using BienvenidosWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.DTOs;

namespace WebAPI.Profiles
{
    public class PaisesProfile : Profile
    {
        public PaisesProfile()
        {
            //Source -> Target
            CreateMap<Pais, PaisLeerDTO>();
            CreateMap<PaisCrearDTO, Pais>();
        }
    }
}
