using System;
using System.Collections.Generic;

namespace BienvenidosWebAPI.Models
{
    public partial class Espacio
    {
        public int Id { get; set; }
        public int IdespacioTipo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public byte[] Foto { get; set; }
        public string Video { get; set; }

        public virtual EspacioTipo IdespacioTipoNavigation { get; set; }
    }
}
