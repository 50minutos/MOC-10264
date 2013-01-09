using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

namespace _003_UpdatePanel
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.PageSize = 10;
            GridView1.AllowPaging = true;
            GridView1.PageIndexChanging += PageIndexChanging;
            GridView1.BackColor = Color.White;
        }

        void PageIndexChanging(Object sender, GridViewPageEventArgs e)
        {
            e.Cancel = false;
        }
    }
}