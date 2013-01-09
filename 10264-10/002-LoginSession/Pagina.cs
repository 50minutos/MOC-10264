using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _002_LoginSession
{
    public class Pagina : System.Web.UI.Page
    {
        protected void Page_PreInit(object sender, EventArgs e)
        {
            if (Session["USUARIO"] == null)
                Response.Redirect("~/Login.aspx");
        }
    }
}