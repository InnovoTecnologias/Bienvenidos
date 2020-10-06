using System;
using System.Collections.Generic;

namespace BienvenidosWebAPI.Models
{
    public partial class Ciudad
    {
        public Ciudad()
        {
            Centro = new HashSet<Centro>();
        }

        public int Id { get; set; }
        public int Idprovincia { get; set; }
        public string Nombre { get; set; }
        public bool Validado { get; set; }
        public string ValidadoPor { get; set; }
        public DateTime? ValidadoFecha { get; set; }

        public virtual Provincia IdprovinciaNavigation { get; set; }
        public virtual ICollection<Centro> Centro { get; set; }
    }
}
