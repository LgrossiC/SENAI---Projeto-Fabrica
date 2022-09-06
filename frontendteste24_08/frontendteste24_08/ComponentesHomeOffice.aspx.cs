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
                connection.Open();
                ListPlacaMãe.Items.Clear();
                var reader = new MySqlCommand("SELECT descrição, id, id_pc FROM componentes WHERE tipo = 'placa mãe'", connection).ExecuteReader();
                while (reader.Read())
                {
                    var item = new ListItem(reader.GetString("descrição"), (reader.GetInt32("id").ToString()));
                    if (reader.GetInt32("id_pc") == 1)
                        item.Selected = true;
                    ListPlacaMãe.Items.Add(item);
                }
                connection.Close();
                
                
            }
        }

        protected void ListPlacaMãe_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}