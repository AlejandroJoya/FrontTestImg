using FrontTestImaginamos.Models;
using System.Web.Mvc;

namespace FrontTestImaginamos.Controllers
{
    public class RegistroController : Controller
    {
        private readonly BackWebServices.MainWebService webService = new BackWebServices.MainWebService();

        [HttpGet]
        // GET: Registro/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Registro/Create
        [HttpPost]
        public ActionResult Create(Registro registro)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    webService.RegistrarUsuario(registro.Nombre, 
                        registro.Documento, 
                        registro.Email, 
                        registro.NombreUsuario, 
                        registro.Contrasena);
                }
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
