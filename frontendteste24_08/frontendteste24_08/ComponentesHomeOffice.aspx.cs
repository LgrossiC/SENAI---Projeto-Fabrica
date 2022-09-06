using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace frontendteste24_08
{
    public partial class ComponentesHomeOffice : System.Web.UI.Page
    {
        private MySqlConnection connection;
        protected void Page_Load(object sender, EventArgs e) //Onde irá carregar as infos.
        {
            connection = new MySqlConnection(SiteMaster.ConnectionString);
            if (!IsPostBack)
            {
                connection.Open(); // gamer
                ListPlacaMãe.Items.Clear();
                var reader = new MySqlCommand("SELECT descrição, id, id_pc FROM componentes WHERE tipo = 'placa mãe'", connection).ExecuteReader();
                while (reader.Read())
                {
                    var item = new ListItem(reader.GetString("descrição"), (reader.GetInt32("id").ToString()));
                    if (reader.GetInt32("id_pc") == 3)
                        item.Selected = true;
                    ListPlacaMãe.Items.Add(item);
                }
                connection.Close();

                connection.Open(); 
                ListProcessador.Items.Clear();
                var reader2 = new MySqlCommand("SELECT descrição, id, id_pc FROM componentes WHERE tipo = 'processador'", connection).ExecuteReader();
                while(reader2.Read())
                {
                    var item = new ListItem(reader2.GetString("descrição"), (reader2.GetInt32("id").ToString()));
                    if (reader2.GetInt32("id_pc") == 3)
                        item.Selected = true;

                    ListProcessador.Items.Add(item);
                }
                connection.Close();

               connection.Open();
                ListFonte.Items.Clear();
                var reader3 = new MySqlCommand("SELECT descrição, id, id_pc FROM componentes WHERE tipo = 'Fonte'", connection).ExecuteReader();
                while(reader3.Read())
                {
                    var item = new ListItem(reader3.GetString("descrição"), (reader3.GetInt32("id").ToString()));
                    if (reader3.GetInt32("id_pc") == 3)
                        item.Selected = true;

                    ListFonte.Items.Add(item);
                }

                connection.Close();

                connection.Open();
                ListArmazenamento.Items.Clear();
                var reader4 = new MySqlCommand("SELECT descrição , id, id_pc FROM componentes WHERE tipo ='SSD'", connection).ExecuteReader();
                while (reader4.Read())

                {
                    var item = new ListItem(reader4.GetString("descrição"), (reader4.GetInt32("id").ToString()));
                    if (reader4.GetInt32("id_pc") == 3)
                        item.Selected = true;
                    ListArmazenamento.Items.Add(item);
                }
                
                connection.Close();


            }
        }

        protected void ListPlacaMãe_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}