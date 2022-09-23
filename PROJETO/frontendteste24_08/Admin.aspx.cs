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
        private MySqlConnection connection2;
        int comprar;

        protected void Page_Load(object sender, EventArgs e) //Quando a página carrega.
        {
            if (!IsPostBack)
            {
            }

            connection = new MySqlConnection(SiteMaster.ConnectionString);
            connection2 = new MySqlConnection(SiteMaster.ConnectionString);

            DataTable tabela = new DataTable();

            tabela.Columns.Add("descricao");
            tabela.Columns.Add("tipo");
            tabela.Columns.Add("comprar");
            tabela.Columns.Add("gastos");


            connection.Open();
            double total_geral = 0;

            var commando = new MySqlCommand($@"select c.descrição, c.tipo, c.estoque, c.valor, sum(quantidade) from participa_componente p
                                                inner join compra v on p.id_compra = v.id
                                                inner join componentes c on p.id_componente = c.id
                                                group by p.id_componente, c.descrição
                                                order by c.descrição;", connection);
            var reader = commando.ExecuteReader();
            while (reader.Read())
            {
                int estoque = reader.GetInt32("estoque");
                int vendidos = reader.GetInt32("sum(quantidade)");

                if (vendidos > estoque)
                {
                    double valor_c = reader.GetDouble("valor");
                    var linha = tabela.NewRow();
                    comprar = vendidos - estoque;
                    double valor_t = valor_c * comprar;
                    total_geral = total_geral + valor_t;
                    linha["descricao"] = reader.GetString("descrição");
                    linha["tipo"] = reader.GetString("tipo");
                    linha["comprar"] = comprar;
                    linha["gastos"] = valor_t.ToString("C");
                    tabela.Rows.Add(linha);
                    Session["tabela"] = tabela;
                    grdComponentes.DataSource = tabela;
                    grdComponentes.DataBind();
                    valor_total.Text = Convert.ToString(total_geral.ToString("C"));
                }
            }
            connection.Close();
        }

        protected void compra_realizada_Click(object sender, EventArgs e)
        {
            connection.Open();
            var commando = new MySqlCommand($@"select c.estoque, sum(quantidade), c.id from participa_componente p
                                                inner join compra v on p.id_compra = v.id
                                                inner join componentes c on p.id_componente = c.id
                                                group by p.id_componente, c.descrição
                                                order by c.descrição;", connection);
            var reader = commando.ExecuteReader();
            while (reader.Read())
            {
                int id = reader.GetInt32("id");
                int estoque = reader.GetInt32("estoque");
                int vendidos = reader.GetInt32("sum(quantidade)");

                if (estoque < vendidos)
                {
                    connection2.Open();
                    var comando1 = new MySqlCommand($@"UPDATE componentes SET estoque = {vendidos} where id = {id}", connection2);
                    comando1.ExecuteNonQuery();
                    connection2.Close();
                }
            }
            connection.Close();
            Response.Redirect("Admin.aspx");
        }
    }
}
