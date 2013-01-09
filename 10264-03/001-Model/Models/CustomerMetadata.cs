using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace _001_Model.Models
{
    public class CustomerMetadata
    {
        [DisplayName("Id:")]
        public int CustomerID { get; set; }

        [DisplayName("Nome:")]
        [Required(ErrorMessage="Preencha o nome")]
        public String FirstName { get; set; }

        //todas as props
    }
}