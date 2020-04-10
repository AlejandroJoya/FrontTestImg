using FrontTestImaginamos.Models;
using System;
using System.Linq;
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
        public ActionResult Create(Producto producto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View();
                }

                webService.AgregarProducto(producto.NombreProducto, producto.Precio, producto.Cantidad);
                
                // TODO: Add insert logic here
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        [HttpGet]
        public ActionResult Detail(long id)
        {
            try
            {
                var producto = webService.ConsultarProducto(id);
                return View(new Producto(producto));
            }
            catch (Exception ex)
            {
                throw;
            }            
        }

        [HttpPost]
        public ActionResult Detail(Producto producto)
        {
            try
            {
                webService.AgregarProductoCarrito(1, producto.Id);
                return RedirectToAction("Index", "Producto");
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
