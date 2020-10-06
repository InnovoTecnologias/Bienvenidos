using System;
using System.Collections.Generic;

namespace BienvenidosWebAPI.Models
{
    public partial class Centro
    {
        public Centro()
        {
            Integrante = new HashSet<Integrante>();
            Practica = new HashSet<Practica>();
        }

        public int Id { get; set; }
        public int Idciudad { get; set; }
        public string Direccion { get; set; }
        public string Nombre { get; set; }
        public byte[] Imagen { get; set; }
        public bool Validado { get; set; }
        public string ValidadoPor { get; set; }
        public DateTime? ValidadoFecha { get; set; }
        public string Video { get; set; }

        public virtual Ciudad IdciudadNavigation { get; set; }
        public virtual ICollection<Integrante> Integrante { get; set; }
        public virtual ICollection<Practica> Practica { get; set; }
    }
}
