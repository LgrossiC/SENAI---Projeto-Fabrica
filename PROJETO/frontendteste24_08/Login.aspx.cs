using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace frontendteste24_08
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnentrar_Click(object sender, EventArgs e)
        {
            if ((txtuser.Text == "admin") && (txtsenha.Text == "admin"))
            {
                Response.Redirect("Admin.aspx");
            }

            else
            {
                SiteMaster.ExibirAlert(this, "Usuário e/ou senha incorreto(s)!");
                txtuser.Text = "";
                txtsenha.Text = "";
            }
        }
    }
}

