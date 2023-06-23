using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Detalle_Venta
    {
        public int iddetalleventa { get; set; }
        public Producto oproducto { get; set; }
        public decimal precioventa { get; set; }
        public int cantidad { get; set; }
        public decimal Subtotal { get; set; }
        public string idtransaccion { get; set; }
        public string fecharegistro { get; set; }
    }
}
