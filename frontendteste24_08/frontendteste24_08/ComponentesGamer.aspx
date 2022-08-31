<%@ Page Title="ComponentesGamer" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ComponentesGamer.aspx.cs" Inherits="frontendteste24_08.ComponentesGamer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
   
    <style> 
        body{background-image:url(/newimgs/bgy.jpg)}
    </style>
                    
    
    <div class="jumbotron text-center">
        
        <h1 style="color:black">Confira abaixo nossos produtos</h1>
           
        <br />
        <br />
    </div>
    <div class="jumbotron">
        <div class="container-fluid">
            <div class="row">
                <div class="col-sm-4"></div>
                <div class="col-sm-4 text-center">
                    <asp:Button runat="server" ID="btnAdicionar"  CssClass="btn btn-success" Text="+" OnClick="btnAdicionar_Click"    />
                </div>
                <div class="col-sm-4 text-right">
                    <asp:Button runat="server" ID="btnFinalizarCompra" CssClass="btn btn-warning" Text="Finalizar Compra" OnClick="btnFinalizarCompra_Click" />
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
    
       
