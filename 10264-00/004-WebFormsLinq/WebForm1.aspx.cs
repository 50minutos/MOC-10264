using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _004_WebFormsLinq
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var cliente = new Proxy.CustomerClient();

            var lista = cliente.Get10().ToList();

            GridView1.DataSource = lista;

            GridView1.DataBind();
        }
    }
}