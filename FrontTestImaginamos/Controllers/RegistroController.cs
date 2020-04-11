using FrontTestImaginamos.Models;
using System;
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
            if (Session["usuario"] != null)
            {
                return RedirectToAction("Index", "Producto");
            }

            return View();
        }

        // POST: Registro/Create
        [HttpPost]
        public ActionResult Create(Registro registro)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View();
                }

                webService.RegistrarUsuario(registro.Nombre,
                    registro.Documento,
                    registro.Email,
                    registro.NombreUsuario,
                    registro.Contrasena);

                ViewBag.RegistroExitoso = true;

                // TODO: Add insert logic here
            }
            catch(Exception ex)
            {
                ModelState.AddModelError(string.Empty, Registro.REGISTO_FALLIDO + " - " + ex.Message);
            }

            return View();
        }
    }
}
