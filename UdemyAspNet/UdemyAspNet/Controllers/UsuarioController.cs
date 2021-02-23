using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UdemyAspNet.Models;

namespace UdemyAspNet.Controllers
{
    public class UsuarioController : Controller
    {
       
        public ActionResult Usuario()
        {
            var usuario = new Usuarios();
            return View(usuario);
        }
        [HttpPost]
        public ActionResult Usuario(Usuarios usuario)
        {
            if (ModelState.IsValid)
            {
                return View("Resultado", usuario);
            }
            return View(usuario);
        }

        public ActionResult Resultado(Usuarios usuario)
        {
            return View(usuario);
        }
    }
}