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
            /*
            if (string.IsNullOrEmpty(usuario.Nome))
            {
                ModelState.AddModelError("Nome", "O campo é obrigatório"); //mostra no campo
            }
            */
            if(usuario.Senha != usuario.ConfirmarSenha)
            {
                ModelState.AddModelError("", "Senhas são diferentes"); //mostra no topo da página
            }
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