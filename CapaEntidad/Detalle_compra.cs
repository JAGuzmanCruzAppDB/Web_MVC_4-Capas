using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Detalle_compra
    {
        public int iddetallecompra { get; set; }
        //idcompra int references compra(id)
        public Producto oproducto { get; set; }
        public decimal preciocompra { get; set; }
        public decimal precioventa { get; set; }
        public decimal cantidad { get; set; }
        public decimal totalcompra { get; set; }
        public decimal totalventa { get; set; }
        public string fecharegistro { get; set; }
    }
}
