using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aula10_MVC.Controllers
{
    public class LancamentoController : Controller
    {
        // GET: Categoria
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult BuscarGrid()
        {
            return View("_Grid");
        }
    }
}