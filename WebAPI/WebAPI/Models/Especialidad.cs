using System;
using System.Collections.Generic;

namespace BienvenidosWebAPI.Models
{
    public partial class Especialidad
    {
        public Especialidad()
        {
            Integrante = new HashSet<Integrante>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Integrante> Integrante { get; set; }
    }
}
