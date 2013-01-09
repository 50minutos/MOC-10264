using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.Routing;

namespace _002_Route
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            RegistrarRotas(RouteTable.Routes);
        }

        private void RegistrarRotas(RouteCollection rotas)
        {
            rotas.MapPageRoute("PesquisaClientes", "clientes/pesquisa", "~/WebForm1.aspx");
            rotas.MapPageRoute("ResultadoPesquisaClientes", "clientes/nome={TEXTO}", "~/WebForm2.aspx");
        }
    }
}