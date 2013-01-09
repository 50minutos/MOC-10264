using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace _002_CRUD.Models
{
    [MetadataType(typeof(PessoaMetadata))]
    public partial class Pessoa
    {

    }

    public class PessoaMetadata
    {
        [Required(ErrorMessage="O nome é obrigatório")]
        public String Nome { get; set; }
    }
}