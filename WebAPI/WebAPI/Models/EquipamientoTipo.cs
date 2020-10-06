using System;
using System.Collections.Generic;

namespace BienvenidosWebAPI.Models
{
    public partial class EquipamientoTipo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public virtual Equipamiento Equipamiento { get; set; }
    }
}
