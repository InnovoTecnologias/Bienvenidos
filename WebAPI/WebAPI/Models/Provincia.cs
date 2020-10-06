using System;
using System.Collections.Generic;

namespace BienvenidosWebAPI.Models
{
    public partial class Provincia
    {
        public Provincia()
        {
            Ciudad = new HashSet<Ciudad>();
        }

        public int Id { get; set; }
        public int Idpais { get; set; }
        public string Nombre { get; set; }
        public bool Validado { get; set; }
        public string ValidadoPor { get; set; }
        public DateTime? ValidadoFecha { get; set; }

        public virtual Pais IdpaisNavigation { get; set; }
        public virtual ICollection<Ciudad> Ciudad { get; set; }
    }
}
