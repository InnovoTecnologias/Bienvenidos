using System;
using System.Collections.Generic;

namespace BienvenidosWebAPI.Models
{
    public partial class Pais
    {
        public Pais()
        {
            Provincia = new HashSet<Provincia>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public bool Validado { get; set; }
        public string ValidadoPor { get; set; }
        public DateTime? ValidadoFecha { get; set; }

        public virtual ICollection<Provincia> Provincia { get; set; }
    }
}
