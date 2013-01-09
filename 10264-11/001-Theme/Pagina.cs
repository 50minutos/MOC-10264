using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _001_Theme
{
    public class Pagina : System.Web.UI.Page
    {
        protected void Page_PreInit(object sender, EventArgs e)
        {
            if (Session["THEME"] == null)
                Session["THEME"] = "Amarelo";

            Page.Theme = Session["THEME"].ToString();
        }
    }
}