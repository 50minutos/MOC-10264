using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _005_Cookie
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Clique(Object o, EventArgs ea)
        {
            var c = new HttpCookie("NOME", Nome.Text);
            c.Expires = DateTime.Now.AddDays(1);

            Response.Cookies.Add(c);

            Response.Redirect("~/WebForm2.aspx");
        }
    }
}