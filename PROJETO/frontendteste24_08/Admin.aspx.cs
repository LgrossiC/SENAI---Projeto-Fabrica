using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySqlConnector;

namespace frontendteste24_08
{
    public partial class Admin : System.Web.UI.Page
    {
        private MySqlConnection connection;
        protected void Page_Load(object sender, EventArgs e) //Quando a página carrega.
        {                                  
            connection.Open();

            connection = new MySqlConnection(SiteMaster.ConnectionString);     
            DataTable tabela = new DataTable();

            tabela.Columns.Add("descricao");
            tabela.Columns.Add("tipo");

            var commando = new MySqlCommand($"SELECT descricao, tipo FROM componentes", connection);
            var reader = commando.ExecuteReader();
            while (reader.Read())
            {
                var linha = tabela.NewRow();
                linha["descricao"] = reader.GetString("descricao");
                linha["tipo"] = reader.GetString("tipo");

                tabela.Rows.Add(linha);
            }
            Session["tabela"] = tabela;
            grdComponentes.DataSource = tabela;
            grdComponentes.DataBind();


            connection.Close();

        }
    }
    }
