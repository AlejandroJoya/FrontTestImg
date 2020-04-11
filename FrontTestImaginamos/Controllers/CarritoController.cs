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
            if (Session["usuario"] == null)
            {
                return RedirectToAction("Index", "Login");
            }

            var usuario = (BackWebServices.UsuarioEntity)Session["usuario"];
            var listaCarrito = webService.ListarCarrito(usuario.Id).ToList();
            return View(listaCarrito);
        }
    }
}
