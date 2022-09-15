<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="frontendteste24_08.Admin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

        <asp:GridView runat="server" CssClass="GridView" ID="grdComponentes" Width="100%" AutoGenerateColumns="false" AllowPaging="false">
        <Columns>
            <asp:BoundField DataField="descricao" HeaderText="DESCRIÇÃO COMPONENTE" />
            <asp:BoundField DataField="tipo" HeaderText="TIPO" />
            <asp:BoundField DataField="comprar" HeaderText="COMPRAR" />
            <asp:BoundField DataField="gastos" HeaderText="GASTOS" />

        </Columns>           
    </asp:GridView>

<asp:TextBox runat="server" ID="valor_total" ></asp:TextBox>



</asp:Content>
