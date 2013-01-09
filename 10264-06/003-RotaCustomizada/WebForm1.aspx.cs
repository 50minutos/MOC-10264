using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _003_RotaCustomizada
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                if(!String.IsNullOrWhiteSpace(Nome.Text))
                    Response.Redirect(String.Format("/produto/{0}", Nome.Text));
                else if (!String.IsNullOrWhiteSpace(Cep.Text))
                    Response.Redirect(String.Format("/cep/{0}", Cep.Text));
        }
    }
}