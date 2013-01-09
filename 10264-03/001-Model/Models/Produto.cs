using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//repository pattern

namespace _001_Model.Models
{
    public class Produto
    {
        public int Codigo { get; set; }
        public String Nome { get; set; }
    }

    public class ProdutoRepository
    {
        public List<Produto> Get()
        {
            var retorno = new List<Produto>();

            //lógica aqui

            return retorno;
        }

        public void Save(Produto p)
        { 
           //lógica aqui
        }
    }
}