using System.Linq;
using System.Web.Mvc;

namespace FrontTestImaginamos.Controllers
{
    public class CarritoController : Controller
    {
        private readonly BackWebServices.MainWebService webService = new BackWebServices.MainWebService();
        // GET: Carrito
        public ActionResult Index()
        {
            var listaCarrito = webService.ListarCarrito(1).ToList();
            return View(listaCarrito);
        }
    }
}
