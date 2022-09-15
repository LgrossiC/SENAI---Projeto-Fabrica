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
                #region LISTAS
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
                //-------------------------------------------------------------------------------------------------------------------------------------------------------------------
                connection.Open();
                ListProcessador.Items.Clear();
                var reader2 = new MySqlCommand("SELECT descrição, id, id_pc FROM componentes WHERE tipo = 'processador'", connection).ExecuteReader();
                while (reader2.Read())
                {
                    var item = new ListItem(reader2.GetString("descrição"), (reader2.GetInt32("id").ToString()));
                    if (reader2.GetInt32("id_pc") == 3)
                        item.Selected = true;
                    ListProcessador.Items.Add(item);
                }
                connection.Close();
                //-------------------------------------------------------------------------------------------------------------------------------------------------------------------
                connection.Open();
                ListFonte.Items.Clear();
                var reader3 = new MySqlCommand("SELECT descrição, id, id_pc FROM componentes WHERE tipo = 'Fonte'", connection).ExecuteReader();
                while (reader3.Read())
                {
                    var item = new ListItem(reader3.GetString("descrição"), (reader3.GetInt32("id").ToString()));
                    if (reader3.GetInt32("id_pc") == 3)
                        item.Selected = true;
                    ListFonte.Items.Add(item);
                }
                connection.Close();
                //-------------------------------------------------------------------------------------------------------------------------------------------------------------------
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
                //-------------------------------------------------------------------------------------------------------------------------------------------------------------------
                connection.Open();
                ListRAM.Items.Clear();
                var reader5 = new MySqlCommand("SELECT descrição , id, id_pc FROM componentes WHERE tipo ='RAM'", connection).ExecuteReader();
                while (reader5.Read())
                {
                    var item = new ListItem(reader5.GetString("descrição"), (reader5.GetInt32("id").ToString()));
                    if (reader5.GetInt32("id_pc") == 3)
                        item.Selected = true;
                    ListRAM.Items.Add(item);
                }
                connection.Close();
                //-------------------------------------------------------------------------------------------------------------------------------------------------------------------
                connection.Open();
                ListGabinete.Items.Clear();
                var reader6 = new MySqlCommand("SELECT descrição , id, id_pc FROM componentes WHERE tipo ='Gabinete'", connection).ExecuteReader();
                while (reader6.Read())
                {
                    var item = new ListItem(reader6.GetString("descrição"), (reader6.GetInt32("id").ToString()));
                    if (reader6.GetInt32("id_pc") == 3)
                        item.Selected = true;
                    ListGabinete.Items.Add(item);
                }
                connection.Close();
                //-------------------------------------------------------------------------------------------------------------------------------------------------------------------
                connection.Open();
                ListPlacaVideo.Items.Clear();
                var reader7 = new MySqlCommand("SELECT descrição , id, id_pc FROM componentes WHERE tipo ='Placa de vídeo'", connection).ExecuteReader();
                while (reader7.Read())
                {
                    var item = new ListItem(reader7.GetString("descrição"), (reader7.GetInt32("id").ToString()));
                    if (reader7.GetInt32("id_pc") == 3)
                        item.Selected = true;
                    ListPlacaVideo.Items.Add(item);
                }
                connection.Close();
                //-------------------------------------------------------------------------------------------------------------------------------------------------------------------
                connection.Open();
                ListSaídaSom.Items.Clear();
                var reader8 = new MySqlCommand("SELECT descrição , id, id_pc FROM componentes WHERE tipo ='Saída de som'", connection).ExecuteReader();
                while (reader8.Read())
                {
                    var item = new ListItem(reader8.GetString("descrição"), (reader8.GetInt32("id").ToString()));
                    if (reader8.GetInt32("id_pc") == 3)
                        item.Selected = true;
                    ListSaídaSom.Items.Add(item);
                }
                connection.Close();
                #endregion

                #region VALORES

                ListPlacaMãe_SelectedIndexChanged(null, null);

                ListPlacaMãe_SelectedIndexChanged(null, null);              

                ListProcessador_SelectedIndexChanged(null, null);
                ListSaídaSom_SelectedIndexChanged(null, null);
                ListPlacaVideo_SelectedIndexChanged(null, null);
                ListGabinete_SelectedIndexChanged(null, null);
                ListArmazenamento_SelectedIndexChanged(null, null);
                ListPlacaMãe_SelectedIndexChanged(null, null);
                ListPlacaMãe_SelectedIndexChanged(null, null);
                ListRAM_SelectedIndexChanged(null, null);
                ListFonte_SelectedIndexChanged(null, null);
                #endregion
            }
        }

        public void CarregaValores(TextBox textBox, DropDownList dropDown)
        {
            connection.Open();
            var reader = new MySqlCommand($"SELECT valor FROM componentes WHERE id = " + dropDown.SelectedValue, connection).ExecuteReader();
            if (reader.Read())
            {
                textBox.Text = reader.GetFloat("valor").ToString("C");
            }
            connection.Close();
        }

        protected void ListPlacaMãe_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregaValores(txtValorPlacaMae, ListPlacaMãe);
        }
        protected void ListProcessador_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregaValores(txtValorProcessador, ListProcessador);

        }

        protected void ListSaídaSom_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregaValores(txtValorSaidaSom, ListSaídaSom);

        }
        protected void ListPlacaVideo_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregaValores(txtValorPlacaVideo, ListPlacaVideo);
        }

        protected void ListGabinete_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregaValores(txtValorGabinete, ListGabinete);
        }        
        protected void ListRAM_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregaValores(txtValorRAM, ListRAM);
        }
        protected void ListArmazenamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregaValores(txtValorArmazenamento, ListArmazenamento);

        }

        protected void ListFonte_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregaValores(txtValorFonte, ListFonte);

        }
             
/*
        protected void ListPlacaMãe_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregaValores(txtValorPlacaMae, ListPlacaMãe);
            ListPlacaMãe.Focus();
        }

        protected void ListProcessador_SelectedIndexChanged(object sender, EventArgs e)

        {
            CarregaValores(txtValorProcessador, ListProcessador);
        }

        protected void ListSaídaSom_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregaValores(txtValorSaidaSom, ListSaídaSom);
        }

        protected void ListPlacaVideo_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregaValores(txtValorPlacaVideo, ListPlacaVideo);
        }

        protected void ListGabinete_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregaValores(txtValorGabinete, ListGabinete);
        }

        protected void ListRAM_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregaValores(txtValorRAM, ListRAM);
        }

        protected void ListArmazenamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregaValores(txtValorArmazenamento, ListArmazenamento);
        }

        protected void ListFonte_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregaValores(txtValorFonte, ListFonte);
            txtMostrarQuantidade.Focus();
        }*/
        
        protected void btnQuantidadeMais_Click(object sender, EventArgs e)
        {
            var qtd = Convert.ToInt32(txtMostrarQuantidade.Text);
            qtd = qtd + 1;
            txtMostrarQuantidade.Text = qtd.ToString();
            txtMostrarQuantidade.Focus();
        }

        protected void btnQuantidadeMenos_Click(object sender, EventArgs e)
        {
            var qtd = Convert.ToInt32(txtMostrarQuantidade.Text);
            qtd = qtd - 1;
            
            if(qtd <= 0)
            {
                qtd = 1;
            }
            txtMostrarQuantidade.Text = qtd.ToString();
            txtMostrarQuantidade.Focus();
        }
       

        protected void btnFinalizarVenda_Click(object sender, EventArgs e)
        {

        }
    }
}