using FrontTestImaginamos.Models;
using System.Web.Mvc;

namespace FrontTestImaginamos.Controllers
{
    public class LoginController : Controller
    {
        private readonly BackWebServices.MainWebService webService = new BackWebServices.MainWebService();
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            if (Session["usuario"] != null)
            {
                return RedirectToAction("Index", "Producto");
            }

            return View();
        }

        [HttpPost]
        public ActionResult Index(Login login)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var usuarioEncontrado = webService.Login(login.Usuario, login.Contrasena);

            if (usuarioEncontrado.Id < 1)
            {
                ModelState.AddModelError(string.Empty, Login.LOGIN_FALLIDO);
                return View();
            }

            Session["usuario"] = usuarioEncontrado;

            return RedirectToAction("Index", "Producto");
        }

        [HttpGet]
        public ActionResult Salir()
        {
            Session.Clear();
            Session.Abandon();
            return RedirectToAction("Index", "Login");
        }
    }
}
