using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Permiso
    {
        public int idpermiso { get; set; }
        public Rol orol { get; set; }
        public string nombremenu { get; set; }
        public string fecharegistro { get; set; }
    }
}
