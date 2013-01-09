using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _003_RotaCustomizada
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (RouteData.Values["NOME"] == null)
                Response.Redirect("~/home");

            Produto.Text = RouteData.Values["NOME"].ToString();
        }
    }
}