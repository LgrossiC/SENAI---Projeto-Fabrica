﻿using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace frontendteste24_08
{
    public partial class ComponentesGamer : System.Web.UI.Page
    {
        private MySqlConnection connection;
        protected void Page_Load(object sender, EventArgs e) //Colocar o que irá ser executado quando a página abrir.
        {      
            connection = new MySqlConnection(SiteMaster.ConnectionString);


        }

        protected void btnAdicionar_Click(object sender, EventArgs e) //Botão para adicionar a quantidade de produtos que deseja comprar.
        {

        }

        protected void grdProdutosGamer_PageIndexChanging(object sender, GridViewPageEventArgs e)   //"Provavelmente não vai ser usado."
        {

        }

        protected void grdProdutosGamer_RowCommand(object sender, GridViewCommandEventArgs e) //Lista que irá mostrar as informações.
        {

        }

        protected void btnFinalizarCompra_Click(object sender, EventArgs e) //Botão para finalizar a compra.
        {

        }

       
    }
}