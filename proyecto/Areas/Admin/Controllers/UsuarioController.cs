using Helper;
using Model;
using proyecto.Areas.Admin.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace proyecto.Areas.Admin.Controllers
{
    [Autenticado]
    public class UsuarioController : Controller
    {
        // GET: Admin/Usuario
        private Usuario usuario = new Usuario();
        private TablaDato dato = new TablaDato();

        public ActionResult Index()
        {
            ViewBag.Paises = dato.Listar("pais");
            return View(usuario.Obtener(SessionHelper.GetUser()));
        }
        public JsonResult Guardar(Usuario model, HttpPostedFileBase Foto)
        {
            var rm = new ResponseModel();

            // Retiramos la validación de esta propiedad
            ModelState.Remove("Password");

            if (ModelState.IsValid)
            {
                rm = model.Guardar(Foto);
            }

            return Json(rm);
        }
    }
}