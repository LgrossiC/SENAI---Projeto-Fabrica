<%@ Page Title="ComponentesGamer" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ComponentesGamer.aspx.cs" Inherits="frontendteste24_08.ComponentesGamer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
   
    <style> 
        body{background-image:url(/newimgs/bgy.jpg)}
    </style>
                    
    
    <div class="jumbotron text-center" style="background-color:#001133">
        
        <h1 style="color:#b3b300">Confira abaixo nossos produtos</h1>
           
        <br />
        <br />
    </div>
    <div class="jumbotron" style="background-color:#001133">
        <div class="container-fluid">
            <div class="row">
                <div class="col-sm-4"></div>
                <div class="col-sm-4 text-center">
                    
                    <!--Botão para adicionar a quantidade da compra-->
                    <asp:Button runat="server" ID="btnAdicionar"  CssClass="btn btn-success" Text="+" OnClick="btnAdicionar_Click"    />
                    <!------------------------------->

                </div>
                <div class="col-sm-4 text-right">
                    
                    <!--Botão para finalizar compra-->
                    <asp:Button runat="server" ID="btnFinalizarCompra" CssClass="btn btn-warning" Text="Finalizar Compra" OnClick="btnFinalizarCompra_Click" />
                    <!------------------------------->

                </div>
            </div>

            <div class="row">
                <asp:GridView runat="server" id="grdProdutosGamer" Width="100%" AutoGenerateColumns="false"
                    CssClass="table table-sm table-bordered table-condensed table-responsive-sm table-hover table-striped"
                    AllowPaging="true" PageSize="10" OnRowCommand="grdProdutosGamer_RowCommand" OnPageIndexChanging="grdProdutosGamer_PageIndexChanging">
                        
                       
                        <Columns>
                            <asp:BoundField HeaderText="Componentes" /> 
                            <asp:BoundField HeaderText="Descrição" />   
                        </Columns>                   

                    </asp:GridView>
                        
            </div>
    
        </div>
    </div>
        
           
    
    
</asp:Content>
    
       
