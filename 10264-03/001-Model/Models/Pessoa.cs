using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Linq.Mapping;

//active record pattern

namespace _001_Model.Models
{
    [Table(Name = "PESSOA")]
    public class Pessoa
    {
        [Column(Name = "COD_PESSOA", IsDbGenerated = true, IsPrimaryKey = true)]
        public int Codigo { get; set; }

        [Column(Name = "NOME_PESSOA")]
        public String Nome { get; set; }

        [Column(Name = "SEXO_PESSOA")]
        public char Sexo { get; set; }

        public void Insert()
        {
            //sua lógica vai aqui!!!
        }

        public void Update()
        {
            //sua lógica vai aqui!!!
        }

        public void Delete()
        {
            //sua lógica vai aqui!!!
        }

        public List<Pessoa> Get(int codigo)
        {
            var retorno = new List<Pessoa>();

            //sua lógica vai aqui!!!

            return retorno;
        }
    }
}