using BienvenidosWebAPI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.DTOs
{
    public class ProvinciaCrearDTO
    {
        [Required]
        public string Nombre { get; set; }
    }
    public class ProvinciaLeerDTO
    {
        [Required]
        public string Nombre { get; set; }
        public int Id { get; set; }
        public int Idpais { get; set; }

        public string Pais { get; set; }
    }
}
