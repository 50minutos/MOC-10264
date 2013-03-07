using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace _003_Helpers.Models
{
    public class Pessoa
    {
        [DisplayName("Código:")]
        public int Codigo { get; set; }

        [DisplayName("Nome:")]
        [Required(AllowEmptyStrings=false, ErrorMessage="preencha o nome")]
        public String Nome { get; set; }

        [DisplayName("Sexo:")]
        public char? Sexo { get; set; }
    }
}