using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _003_CustomError
{
    public partial class Erro404 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Msg.Text = "O endereço " + Request.QueryString["aspxerrorpath"] + " não existe";
        }
    }
}