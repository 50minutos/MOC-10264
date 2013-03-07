using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using _002_WebForms.Wcf;

namespace _002_WebForms
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(CustomerID.Text))
            {
                var customerID = Int32.Parse(CustomerID.Text);

                var cliente = new CustomerClient();

                var c = cliente.Get(customerID);

                if (c != null)
                    FirstName.Text = c.FirstName;
            }
        }
    }
}