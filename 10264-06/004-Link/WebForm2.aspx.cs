using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _004_Link
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (RouteData.Values["CATEGORIA"] == null || RouteData.Values["PRODUTO"] == null)
                Response.Redirect("/home");

            Response.Write(String.Format("<p>{0}</p>", RouteData.Values["CATEGORIA"].ToString()));
            Response.Write(String.Format("<p>{0}</p>", RouteData.Values["PRODUTO"].ToString()));
        }
    }
}