using System;
using System.Web.Mvc;
using UdemyAspNet.Models;

namespace UdemyAspNet.Controllers
{
    public class HomeController : Controller //extende a classe Controller
    {
        // GET: Home
        public String Index2() //metodo chamado index do tipo string
        {
            return "<h1>Paulo Roberto</h1>"; //retorna esse texto
        }

        public String Teste() //retorna uma string tb
        {
           

            return "<h2>Teste</h2>"; //retorna esse texto
        }

        public ActionResult Index()
        {
            //receber e passar informações da model pessoa
            //cria um objeto pessoa com seus dados
            var pessoa = new Pessoa()
            {
                PessoaId = 1,
                PessoaNome = "Nome de teste",
                Tipo = "Administrador"

            };

            var pessoa2 = new Pessoa();
            pessoa2.PessoaId = 2;
            pessoa2.PessoaNome = "Mais um";
            pessoa2.Tipo = "Usuário";

            var pessoa3 = new Pessoa();
            pessoa3.PessoaId = 3;
            pessoa3.PessoaNome = "Mais outro";
            pessoa3.Tipo = "Gerencia";

            //passando os parametros primeiro jeito - viewdata
            ViewData["PessoaId"] = pessoa.PessoaId;
            ViewData["PessoaNome"] = pessoa.PessoaNome;
            ViewData["Tipo"] = pessoa.Tipo;

            //passando os parametros com viewbag
            ViewBag.id = pessoa2.PessoaId;
            ViewBag.nome = pessoa2.PessoaNome;
            ViewBag.tipo = pessoa2.Tipo;

            //passando view tipada

            return View(pessoa3);
        }

        public ActionResult Contatos()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Lista(Pessoa pessoa)
        {
             return View(pessoa);
        }
       
    }
}