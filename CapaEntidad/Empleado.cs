using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Empleado
    {
        public int idempleado { get; set; }
        public string nombreempleado { get; set; }
        public string apellidos { get; set; }
        public string correo { get; set; }
        public string clave { get; set; }
        //public bool reestablecer { get; set; }
        public bool estado { get; set; }
        public string fecharegistro { get; set; }
    }
}
