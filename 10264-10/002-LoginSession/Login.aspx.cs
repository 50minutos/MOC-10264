using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace _002_LoginSession
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            var cs = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|Banco.mdf;Integrated Security=True;User Instance=True";

            using (var c = new SqlConnection(cs))
            {
                var cmd = "SELECT COUNT(*) FROM USUARIO WHERE LOGIN = @LOGIN AND SENHA = @SENHA";
                using (var k = new SqlCommand(cmd, c))
                {
                    k.Parameters.AddWithValue("@LOGIN", Nome.Text);
                    k.Parameters.AddWithValue("@SENHA", Senha.Text);
                    
                    c.Open();

                    int x = Convert.ToInt32(k.ExecuteScalar());

                    c.Close();

                    if (x == 1)
                    {
                        Session["USUARIO"] = Nome.Text + "|" + Senha.Text;
                        Response.Redirect("~/WebForm1.aspx");
                    }
                }
            }
        }
    }
}