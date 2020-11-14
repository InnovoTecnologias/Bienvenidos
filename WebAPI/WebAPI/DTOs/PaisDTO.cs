using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.DTOs
{
    public class PaisCrearDTO
    {
        [Required]
        public string Nombre { get; set; }
    }
    public class PaisLeerDTO
    {
        [Required]
        public string Nombre { get; set; }
        public int Id { get; set; }
    }
}
