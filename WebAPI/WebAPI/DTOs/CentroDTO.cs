using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BienvenidosWebAPI.DTOs
{
    public class CentroAltaDTO
    {
        [Required]
        [MaxLength(250)]
        public string Nombre { get; set; }

        [Required]
        public string Direccion { get; set; }
        public string Video { get; set; }
        public byte[] Imagen { get; set; }
    }

    public class CentroLeerDTO
    {
        [Required]
        [MaxLength(250)]
        public string Nombre { get; set; }

        [Required]
        public string Direccion { get; set; }
        public string Video { get; set; }
        public byte[] Imagen { get; set; }
    }
}
