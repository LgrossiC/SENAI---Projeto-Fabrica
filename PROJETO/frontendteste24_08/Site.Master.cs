using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace frontendteste24_08
{
    public partial class SiteMaster : MasterPage
    {
<<<<<<< HEAD:frontendteste24_08/frontendteste24_08/Site.Master.cs
<<<<<<< HEAD
        public static string ConnectionString = "Server=127.0.0.1;User ID=root;Password=;Database=vendapc";
=======
        public static string ConnectionString = "Server=127.0.0.1;User ID=root;Password=;Database=loja_pc";
>>>>>>> e14c58d72ad74b6c3034f60733860c8b909b4001
=======
        public static string ConnectionString = "Server=127.0.0.1;User ID=root;Password=;Database=loja_pc";
>>>>>>> d3b27d650c490432690f69392bc604ca954f20c0:PROJETO/frontendteste24_08/Site.Master.cs
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public static void ExibirAlert(Page page, string mensagem)
        {
            page.ClientScript.RegisterStartupScript(
                 page.GetType(),
                 "MessageBox" + Guid.NewGuid(),
                 "<script language='javascript'>alert('" + mensagem + "');</script>"
              );
        }
    }
}