using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _002_UnitTest
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write(Somar(1, 3));
            Response.Write("<br/>");
            Response.Write(Subtrair(1, 3));
            Response.Write("<br/>");
            Response.Write(Multiplicar(1, 3));
            Response.Write("<br/>");
            Response.Write(Dividir(1, 3));
        }

        public double Somar(double x, double y) { return x + y; }

        public double Subtrair(double x, double y) { return x - y; }
        
        public double Multiplicar(double x, double y) { return x * y; }
        
        public double Dividir(double x, double y) { return x / y; }

        public void Dormir() { /*Response.Write("zzzzzz");*/ }
    }
}