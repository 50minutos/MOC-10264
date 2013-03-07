using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _005_Cookie
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["NOME"] == null) 
                Response.Redirect("~/webform1.aspx");
            
            Response.Write(Request.Cookies["NOME"].Value);
        }
    }
}