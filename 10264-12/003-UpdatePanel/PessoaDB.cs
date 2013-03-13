using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _003_UpdatePanel
{
    public class PessoaDB
    {
        private static List<Pessoa> pessoas = new List<Pessoa>();
       
        private static Random r;

        static PessoaDB()
        {
            r = new Random();

            int i = 1;

            while (i <= 1000)
            {
                pessoas.Add(new Pessoa { Codigo = i++, Nome = ObterNome()});    
            }
        }

        private static string ObterNome()
        {
            var retorno = String.Empty;

            var qtd = r.Next(10, 21);

            for (int i = 0; i < qtd; i++)
            {
                retorno += ((char)r.Next(65, 98)).ToString();
            }

            return retorno;
        }

        public List<Pessoa> Get() { return pessoas; }
    }
}