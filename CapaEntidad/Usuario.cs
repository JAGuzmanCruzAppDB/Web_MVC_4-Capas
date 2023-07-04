using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Usuario
    {
        public int idusuario { get; set; }
        //public Rol orol { get; set; }
        public string nombreusuario { get; set; }
        public string nombrecompleto { get; set; }
        public string correo { get; set; }
        public string clave { get; set; }
        public bool reestablecer { get; set; }
        public bool estado { get; set; }
        public string fecharegistro { get; set; }
    }
}
