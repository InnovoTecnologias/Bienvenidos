using AutoMapper;
using BienvenidosWebAPI.DTOs;
using BienvenidosWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.DTOs;

namespace WebAPI.Profiles
{
    public class CentrosProfile : Profile
    {
        public CentrosProfile()
        {
            //Source -> Target
            CreateMap<Centro, CentroLeerDTO>();
            CreateMap<CentroAltaDTO, Centro>();
        }
    }
}
