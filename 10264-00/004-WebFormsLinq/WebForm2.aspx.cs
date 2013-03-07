using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _004_WebFormsLinq
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(CustomerID.Text))
            {
                var customerID = Int32.Parse(CustomerID.Text);

                var cliente = new Proxy.CustomerClient();

                var c = cliente.Get(customerID);

                if (c != null)
                    FirstName.Text = c.FirstName;
            }
        }
    }
}