using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _001_Refactoring
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //encapsular campo -> CTRL+R, CTRL+E
            //extrair método -> CTRL+R, CTRL+M
            //extrair interface -> CTRL+R, CTRL+I

            Escrever();

            int x = 10, y = 20;
            int z;
            z = Somar(x, y);

            var p = new Pessoa();
            p.Codigo = 1;
            p.Nome = "Adão";

            Response.Write(p.Acordar());
            Response.Write(p.Comer());
            Response.Write(p.Dormir());

            Console.WriteLine(p);
        }

        private int Somar(int x, int y)
        {
            return x + y;
        }

        private void Escrever()
        {
            Response.Write("oi");
            Response.Write("<br/>");
            Response.Write("oi");
            Response.Write("<br/>");
            Response.Write("oi");
            Response.Write("<br/>");
            Response.Write("oi");
        }
    }

    public class Pessoa : IPessoa 
    {
        private int codigo;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Nome { get; set; }

        public String Acordar()
        {
            return "acordou";
        }

        public String Comer()
        {
            return "comeu";
        }

        public String Dormir()
        {
            return "dormiu";
        }
    }
}