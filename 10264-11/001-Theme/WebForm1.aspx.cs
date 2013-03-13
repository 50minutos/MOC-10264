using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _001_Theme
{
    public partial class WebForm1 : Pagina
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void TrocarTheme(object sender, EventArgs e)
        {
            Session["THEME"] = DDL.SelectedItem;
           
            Response.Redirect("~/Sucesso.aspx");
        }
    }
}