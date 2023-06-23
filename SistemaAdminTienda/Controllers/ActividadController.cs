using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SistemaAdminTienda.Controllers
{
    public class ActividadController : Controller
    {
        // GET: Actividad
        public ActionResult Ventas()
        {
            return View();
        }
        public ActionResult Compras()
        {
            return View();
        }
    }
}