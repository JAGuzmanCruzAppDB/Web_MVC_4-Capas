using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Venta
    {
        /*
         create table venta(
        id int primary key identity,
        idempleado int references empleado(idempleado),
        numerodocumento int,
        plaza varchar(60),
        montototal decimal(10,2),
        fecharegistro datetime default getdate()
)
         */
        public int idventa { get; set; }
        public Empleado oempleado { get; set; }
        public int numerodocumento { get; set; }
        public string plaza { get; set; }
        public decimal montototal { get; set; }
        public List<Detalle_Venta> detalle_Venta { get; set; }
        public string fecharegistro { get; set; }
    }
}
