using FrontTestImaginamos.Models;
using System.Web.Mvc;

namespace FrontTestImaginamos.Controllers
{
    public class LoginController : Controller
    {
        private readonly BackWebServices.MainWebService webService = new BackWebServices.MainWebService();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Login login)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            bool esValido = webService.Login(login.Usuario, login.Contrasena);

            if (!esValido)
            {
                ModelState.AddModelError(string.Empty, Login.LOGIN_FALLIDO);
            }

            return View();
        }
    }
}
