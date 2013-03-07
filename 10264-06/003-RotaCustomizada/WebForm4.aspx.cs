using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _003_RotaCustomizada
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (RouteData.Values["CATEGORIA"] == null ||
RouteData.Values["PRODUTO"] == null)
                Response.Redirect("/home");
            
            Categoria.Text = RouteData.Values["CATEGORIA"].ToString();
            Produto.Text = RouteData.Values["PRODUTO"].ToString();
        }
    }
}