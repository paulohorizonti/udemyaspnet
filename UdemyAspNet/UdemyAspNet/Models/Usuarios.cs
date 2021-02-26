using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UdemyAspNet.Models
{
    public class Usuarios
    {
        [Required(ErrorMessage ="O nome é obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage ="Campo observações é obrigatório")]
        [StringLength(50, MinimumLength =10, ErrorMessage = "O mínimo são 50 caracteres")]
        public string Obs { get; set; }

        [Range(18,70, ErrorMessage ="Idade entre 18 e 70")]
        public string Idade { get; set; }

        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Insira uma e-mail válido")]
        public string Email { get; set; }

        [RegularExpression(@"[a-zA-Z]{5, 15}", ErrorMessage ="Somente letras e de 5 a 15")]
        [Required(ErrorMessage = "Campo é obrigatório")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Campo senha é obrigatório")]
     
        public string Senha { get; set; }

        [Required(ErrorMessage = "Campo repetir senha é obrigatório")]
        [Compare("Senha", ErrorMessage ="As senhas não são iguais")]
        public string ConfirmarSenha { get; set; }
    }
}