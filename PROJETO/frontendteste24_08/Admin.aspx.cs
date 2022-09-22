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
            if (!IsPostBack)
            {
            }

            connection = new MySqlConnection(SiteMaster.ConnectionString);    
                         
            DataTable tabela = new DataTable();

            tabela.Columns.Add("descricao");
            tabela.Columns.Add("tipo");
            tabela.Columns.Add("comprar");
            tabela.Columns.Add("gastos");

            connection.Open();
            var commando1 = new MySqlCommand($@"select sum(quantidade), p.id_componente from participa_componente p
                                                inner join compra v on p.id_compra = v.id
                                                inner join componentes c on p.id_componente = c.id
                                                group by p.id_componente, c.descrição
                                                order by c.descrição;", connection);
            var reader = commando1.ExecuteReader();
            while (reader.Read())
            {
                int vendidos = reader.GetInt32("sum(quantidade)");
            }
            connection.Close();

            connection.Open();
            double total_geral = 0;

            var commando = new MySqlCommand($"SELECT descrição, tipo, estoque, valor FROM componentes", connection);
            reader = commando.ExecuteReader();
            while (reader.Read())
            {             
                int estoque = reader.GetInt32("estoque");
                double valor_c = reader.GetDouble("valor");             
                var linha = tabela.NewRow();
                linha["descricao"] = reader.GetString("descrição");
                linha["tipo"] = reader.GetString("tipo");

                int comprar = vendidos-estoque;

                double valor_t = valor_c * comprar;
                total_geral = total_geral + valor_t;
                linha["comprar"] = comprar;
                linha["gastos"] = valor_t.ToString("C");


                tabela.Rows.Add(linha);
            }
            Session["tabela"] = tabela;
            grdComponentes.DataSource = tabela;
            grdComponentes.DataBind();

            
            connection.Close();
            valor_total.Text = Convert.ToString(total_geral.ToString("C"));


        }


        protected void compra_realizada_Click(object sender, EventArgs e)
        {
            connection.Open();
            var comando = new MySqlCommand($@"UPDATE componentes SET estoque = {1000}", connection);
            comando.ExecuteNonQuery();
            connection.Close();
            Response.Redirect("Admin.aspx");
        }
    }
}
