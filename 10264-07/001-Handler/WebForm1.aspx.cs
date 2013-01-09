using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Drawing;

namespace _001_Handler
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CriarDados(GridView1);
        }

        private void CriarDados(GridView x)
        {
            var lista = new List<Pessoa>();

            lista.Add(new Pessoa { Codigo = 1, Nome = "ADÃO" });
            lista.Add(new Pessoa { Codigo = 2, Nome = "EVA" });
            lista.Add(new Pessoa { Codigo = 3, Nome = "CAIM" });
            lista.Add(new Pessoa { Codigo = 4, Nome = "ABEL" });

            x.DataSource = lista;

            x.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var stringWriter = new StringWriter();
            var htmlWriter = new HtmlTextWriter(stringWriter);
            
            var gv = new GridView();
            
            gv.HeaderStyle.ForeColor = Color.Black;
            gv.HeaderStyle.BackColor = Color.AntiqueWhite;
            gv.AlternatingRowStyle.BackColor = Color.GhostWhite;
            gv.RowStyle.BackColor = Color.White;
            
            CriarDados(gv);
            
            gv.RenderControl(htmlWriter);
            
            Session["DADOS"] = stringWriter.ToString();

            Response.Redirect("~/HandlerExcel.ashx");
        }
    }

    class Pessoa
    {
        public int Codigo { get; set; }
        public String Nome { get; set; }
    }
}