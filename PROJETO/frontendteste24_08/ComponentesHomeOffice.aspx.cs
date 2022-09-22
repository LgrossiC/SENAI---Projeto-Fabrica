using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
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
                var id_pc = Convert.ToInt32(Request.QueryString["id"].ToString());

                #region LISTAS
                connection.Open(); // gamer
                ListPlacaMãe.Items.Clear();
                var reader = new MySqlCommand("SELECT descrição, id, id_pc FROM componentes WHERE tipo = 'placa mãe'", connection).ExecuteReader();
                while (reader.Read())
                {
                    var item = new ListItem(reader.GetString("descrição"), (reader.GetInt32("id").ToString()));
                    if (reader.GetInt32("id_pc") == id_pc)
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
                    if (reader2.GetInt32("id_pc") == id_pc)
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
                    if (reader3.GetInt32("id_pc") == id_pc)
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
                    if (reader4.GetInt32("id_pc") == id_pc)
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
                    if (reader5.GetInt32("id_pc") == id_pc)
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
                    if (reader6.GetInt32("id_pc") == id_pc)
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
                    if (reader7.GetInt32("id_pc") == id_pc)
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
                    if (reader8.GetInt32("id_pc") == id_pc)
                        item.Selected = true;
                    ListSaídaSom.Items.Add(item);
                }
                connection.Close();
                #endregion

                #region VALORES
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
        }

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

            if (qtd <= 0)
            {
                qtd = 1;
            }
            txtMostrarQuantidade.Text = qtd.ToString();
            txtMostrarQuantidade.Focus();
        }


        bool ValidaEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        public static Boolean VerificaCnpj(String cnpj)

        {

            if (Regex.IsMatch(cnpj, @"(^(\d{2}.\d{3}.\d{3}/\d{4}-\d{2})|(\d{14})$)"))

            {

                return validaCnpj(cnpj);

            }

            else

            {

                return false;

            }

        }

        private static Boolean validaCnpj(String cnpj)

        {

            Int32[] digitos, soma, resultado;

            Int32 nrDig;

            String ftmt;

            Boolean[] cnpjOk;

            cnpj = cnpj.Replace("/", "");

            cnpj = cnpj.Replace(".", "");

            cnpj = cnpj.Replace("-", "");

            if (cnpj == "00000000000000")

            {

                return false;

            }

            ftmt = "6543298765432";

            digitos = new Int32[14];

            soma = new Int32[2];

            soma[0] = 0;

            soma[1] = 0;

            resultado = new Int32[2];

            resultado[0] = 0;

            resultado[1] = 0;

            cnpjOk = new Boolean[2];

            cnpjOk[0] = false;

            cnpjOk[1] = false;

            try
            {
                for (nrDig = 0; nrDig < 14; nrDig++)

                {

                    digitos[nrDig] = int.Parse(cnpj.Substring(nrDig, 1));

                    if (nrDig <= 11)

                        soma[0] += (digitos[nrDig] *

                        int.Parse(ftmt.Substring(nrDig + 1, 1)));

                    if (nrDig <= 12)

                        soma[1] += (digitos[nrDig] *

                        int.Parse(ftmt.Substring(nrDig, 1)));

                }

                for (nrDig = 0; nrDig < 2; nrDig++)

                {

                    resultado[nrDig] = (soma[nrDig] % 11);

                    if ((resultado[nrDig] == 0) || (resultado[nrDig] == 1))

                        cnpjOk[nrDig] = (digitos[12 + nrDig] == 0);

                    else

                        cnpjOk[nrDig] = (digitos[12 + nrDig] == (

                        11 - resultado[nrDig]));

                }

                return (cnpjOk[0] && cnpjOk[1]);
            }
            catch

            {
                return false;

            }

        }

        protected void btnFinalizarVenda_Click(object sender, EventArgs e) //BOTÃO PARA FINALIZAR VENDA.
        {
            if ((txtNomeUsuario.Text == "") || (txtEmailUsuario.Text == "") || (txtCnpjUsuario.Text == ""))
            {
                SiteMaster.ExibirAlert(this, "Todos os campos são obrigatórios");
                return;
            }

            string email_user = Convert.ToString(txtEmailUsuario.Text);
            string cnpj_user = Convert.ToString(txtCnpjUsuario.Text);

            if (validaCnpj(cnpj_user) == false)
            {
                SiteMaster.ExibirAlert(this, "Cnpj inválido!");
                return;
            }

            if (ValidaEmail(email_user) == false)
            {
                SiteMaster.ExibirAlert(this, "E-mail inválido!");
                return;
            }

            var id_pc = Convert.ToInt32(Request.QueryString["id"].ToString());

            connection.Open();
            var insert_clientes = new MySqlCommand($@"
            INSERT INTO clientes (nome, cnpj, email)
            VALUES ('{txtNomeUsuario.Text}','{txtCnpjUsuario.Text}','{txtEmailUsuario.Text}' )", connection);
            insert_clientes.ExecuteNonQuery();
            connection.Close();

            connection.Open();
            var reader_cliente = new MySqlCommand("SELECT MAX(id) from clientes", connection).ExecuteReader();
            reader_cliente.Read();
            var id_cliente = reader_cliente.GetInt32(0);
            connection.Close();

            connection.Open();
            var insert_compra = new MySqlCommand($@"
            INSERT INTO compra (quantidade, id_pc, id_cliente)
            VALUES ('{txtMostrarQuantidade.Text}','{id_pc}','{id_cliente}')", connection);
            insert_compra.ExecuteNonQuery();
            connection.Close();

            connection.Open();
            var reader_compra = new MySqlCommand("SELECT MAX(id) from compra", connection).ExecuteReader();
            reader_compra.Read();
            var id_compra = reader_compra.GetInt32(0);
            connection.Close();

            List<DropDownList> lista_drop = new List<DropDownList>
            {
                ListPlacaMãe,
                ListProcessador,
                ListFonte,
                ListArmazenamento,
                ListRAM,
                ListGabinete,
                ListPlacaVideo,
                ListSaídaSom
            };

            List<TextBox> lista_txt = new List<TextBox>
            {
                txtValorPlacaMae,
                txtValorProcessador,
                txtValorFonte,
                txtValorArmazenamento,
                txtValorRAM,
                txtValorGabinete,
                txtValorPlacaVideo,
                txtValorSaidaSom
            };

            for (int i = 0; i < lista_drop.Count; i++)
            {
                connection.Open();
                var id_componente = lista_drop[i].SelectedValue;
                var insert_participa = new MySqlCommand($@"
                INSERT INTO participa_componente (id_componente, valor, id_compra)
                VALUES ('{id_componente}', '{lista_txt[i].Text.Replace(",", ".").Replace("R$ ", "")}', '{id_compra}')", connection);
                insert_participa.ExecuteNonQuery();
                connection.Close();
            }

            connection.Close();

            SiteMaster.ExibirAlert(this, "Compra realizada com sucesso!");
            txtNomeUsuario.Text = "";
            txtEmailUsuario.Text = "";
            txtCnpjUsuario.Text = "";
        }
    }

}


