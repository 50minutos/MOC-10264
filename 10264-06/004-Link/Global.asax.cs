using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.Routing;

namespace _003_RotaCustomizada
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            RegistrarRotas(RouteTable.Routes);
        }

        private void RegistrarRotas(RouteCollection rotas)
        {
            rotas.MapPageRoute("Home", "home", "~/WebForm1.aspx");
            rotas.MapPageRoute("PesquisaProdutos", "produto/{CATEGORIA}/{PRODUTO}", "~/WebForm2.aspx");
        }
    }
}