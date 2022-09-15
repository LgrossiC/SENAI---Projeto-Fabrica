<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="frontendteste24_08.Admin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <style>
        @import url('https://fonts.googleapis.com/css?family=Lato:200');


        .abadecima{
            background-color:black;
            
        }

        body {  
            background-image: url(/imgs/preto.jpg);
            background: linear-gradient(75deg, rgba(2,6,56,1) 0%, rgba(1,4,41,1) 5%, rgba(0,2,22,1) 12%, rgba(0,0,0,1) 61%, rgba(0,0,0,1) 70%, rgba(0,4,54,1) 86%, rgba(0,3,51,1) 97%);
            
        }       

        .fontedotitulo{
            color:white;
        }

        .iconpgamer {
            border-radius: 8px;
            font-family:broken
        }

        .bordercontainer {
            border-color: white;
            border-style: solid;
        }

        .margen {
            margin: 4px 0 0 4px;
            box-shadow: 0 0 0 4px #fff;
        }
        
        .borderimage {
           border-image:30 round;
        }


        .grid{
            color:white;
           background: linear-gradient(180deg, rgba(2,0,36,1) 0%, rgba(0,0,0,1) 3%, rgba(0,0,50,1) 71%);
           font-family: Console;
           font-size:25px;
        }
    </style>    
    <br />
    <div class="jumbotron grid">

       <h1 class="text-center" style="color:white; font-family:Monaco">INFORMAÇÕES DA VENDA</h1>
        <asp:GridView runat="server" CssClass="GridView" ID="grdComponentes" Width="100%" AutoGenerateColumns="false" AllowPaging="false">
        <Columns>
            <asp:BoundField DataField="descricao" HeaderText="DESCRIÇÃO COMPONENTE" />
            <asp:BoundField DataField="tipo" HeaderText="TIPO" />
            <asp:BoundField DataField="comprar" HeaderText="COMPRAR" />
            <asp:BoundField DataField="gastos" HeaderText="GASTOS" />

        </Columns>           
    </asp:GridView>
    </div>

<asp:TextBox runat="server" ID="valor_total" ></asp:TextBox>



</asp:Content>
