using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Compra
    {
        public int idCompra { get; set; }
        public Usuario ousuario { get; set; }
        public string numerodocumento { get; set; }
        public decimal totalcompra { get; set; }
        public decimal totalventa { get; set; }
        public List<Detalle_compra> odetallecompra { get; set; }
        public string fecharegistro { get; set; }
    }
}
