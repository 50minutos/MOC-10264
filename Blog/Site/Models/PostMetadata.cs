using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Site.Models
{
    public class PostMetadata
    {
        [DisplayName("Código do post:")]
        public int Cod { get; set; }

        [Required(ErrorMessage = "Preencha o título")]
        [DisplayName("Título:")]
        public String Titulo { get; set; }

        [Required(ErrorMessage = "Preencha o conteúdo")]
        [DisplayName("Conteúdo do post:")]
        public String Conteudo { get; set; }

        [DisplayName("Usuário:")]
        public int CodUsuario { get; set; }
    }
}