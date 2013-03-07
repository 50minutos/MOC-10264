using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//data mapper patern

namespace _001_Model.Models
{
    public class Livro
    {
        public int Codigo { get; set; }
        public String Titulo { get; set; }
    }

    public class LivroMapper
    {
        public void Insert(Livro v)
        {
            //sua lógica vai aqui!!!
        }

        public void Update(Livro v)
        {
            //sua lógica vai aqui!!!
        }

        public void Delete(Livro v)
        {
            //sua lógica vai aqui!!!
        }

        public List<Livro> Get(int codigo = 0)
        {
            var retorno = new List<Livro>();

            //sua lógica vai aqui!!!

            return retorno;
        }
    }
}
 