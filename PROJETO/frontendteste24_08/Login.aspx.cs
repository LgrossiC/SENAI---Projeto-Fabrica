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

        protected void btnentrar_Click(object sender, EventArgs e) // botão que confirma as credenciais para liberar acesso à página do admin.
        {

            if ((txtuser.Text == "admin") && (txtsenha.Text == "admin"))  // compara se usuário e senha específicos para acesso do administrador ao relatório estão corretos.
            {
                Session["logado"] = "sim";  // inicia a sessão e caso a conexão do usuário esteja inativa ele perderá o acesso automaticamente.
                Response.Redirect("Admin.aspx"); // ao ter a sessão iniciada, o admin é redirecionado à página do relatório.

            }

            else
            {
                SiteMaster.ExibirAlert(this, "Usuário e/ou senha incorreto(s)!"); // se as credenciais de acesso do admin não estiverem corretas, será exibida esta mensagem de erro.
                txtuser.Text = "";  // após a mensagem de erro ser exibida as textboxes de usuário e senha serão limpas.
                txtsenha.Text = "";
            }
        }
    }
    
}

