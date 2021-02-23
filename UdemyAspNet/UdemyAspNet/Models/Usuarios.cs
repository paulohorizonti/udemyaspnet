using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UdemyAspNet.Models
{
    public class Usuarios
    {
        public string Nome { get; set; }
        public string Obs { get; set; }
        public string Idade { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string ConfirmarSenha { get; set; }
    }
}