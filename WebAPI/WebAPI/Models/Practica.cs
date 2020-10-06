using System;
using System.Collections.Generic;

namespace BienvenidosWebAPI.Models
{
    public partial class Practica
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Video { get; set; }
        public int Idcentro { get; set; }

        public virtual Centro IdcentroNavigation { get; set; }
    }
}
