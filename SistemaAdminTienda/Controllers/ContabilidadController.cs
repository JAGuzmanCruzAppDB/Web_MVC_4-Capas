using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SistemaAdminTienda.Controllers
{
    public class ContabilidadController : Controller
    {
        // GET: Contabilidad
        public ActionResult ContaCompras()
        {
            return View();
        }
        public ActionResult ContaVentas()
        {
            return View();
        }
    }
}