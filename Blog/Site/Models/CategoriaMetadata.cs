using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Site.Models
{
    public class CategoriaMetadata
    {
        [DisplayName("Código da categoria:")]
        public int Cod { get; set; }

        [Required(ErrorMessage = "Preencha a descrição")]
        [DisplayName("Descrição da categoria:")]
        public String Descricao { get; set; }
    }
}