using System;
using System.Collections.Generic;

namespace BienvenidosWebAPI.Models
{
    public partial class Equipamiento
    {
        public int Id { get; set; }
        public int IdequipamientoTipo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public byte[] Foto { get; set; }
        public string Video { get; set; }

        public virtual EquipamientoTipo IdequipamientoTipoNavigation { get; set; }
    }
}
