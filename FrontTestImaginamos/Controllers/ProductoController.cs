using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FrontTestImaginamos.Controllers
{
    public class ProductoController : Controller
    {
        private readonly BackWebServices.MainWebService webService = new BackWebServices.MainWebService();
        // GET: Producto
        public ActionResult Index()
        {
            var listaProductos = webService.ListarProductos().ToList();
            return View(listaProductos);
        }

        // GET: Producto/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Producto/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
