using AutoMapper;
using BienvenidosWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.DTOs;

namespace WebAPI.Profiles
{
    public class ProvinciasProfile : Profile
    {
        public ProvinciasProfile()
        {
            //Source -> Target
            CreateMap<Provincia, ProvinciaLeerDTO>();
            CreateMap<ProvinciaCrearDTO, Provincia>();
        }
    }
}
