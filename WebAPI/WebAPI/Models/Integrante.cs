using System;
using System.Collections.Generic;

namespace BienvenidosWebAPI.Models
{
    public partial class Integrante
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Idcentro { get; set; }
        public string Descripcion { get; set; }
        public byte[] Foto { get; set; }
        public int Idespecialidad { get; set; }
        public string Video { get; set; }

        public virtual Centro IdcentroNavigation { get; set; }
        public virtual Especialidad IdespecialidadNavigation { get; set; }
    }
}
