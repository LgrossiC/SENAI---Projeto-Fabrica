<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="frontendteste24_08.Admin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

        <asp:GridView runat="server" CssClass="GridView" ID="grdComponentes" Width="100%" AutoGenerateColumns="false" OnRowCommand="grdComponentes_RowCommand" AllowPaging="true" PageSize="20">
        <Columns>
            <asp:BoundField DataField="descricao" HeaderText="DESCRIÇÃO" />
            <asp:BoundField DataField="tipo" HeaderText="TIPO" />
        </Columns>

    </asp:GridView>
</asp:Content>
