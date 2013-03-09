using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Site.Models
{
    public class UsuarioMetadata
    {
        
        public int Cod { get; set; }

        [Required(ErrorMessage = "Preencha o nome")]
        [DisplayName("Nome do usuário:")]
        public String Nome { get; set; }

        [Required(ErrorMessage = "Preencha a senha")]
        [DisplayName("Senha do usuário:")]
        public String Senha { get; set; }
    }
}