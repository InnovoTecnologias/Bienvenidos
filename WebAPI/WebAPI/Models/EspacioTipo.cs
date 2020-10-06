using System;
using System.Collections.Generic;

namespace BienvenidosWebAPI.Models
{
    public partial class EspacioTipo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public virtual Espacio Espacio { get; set; }
    }
}
