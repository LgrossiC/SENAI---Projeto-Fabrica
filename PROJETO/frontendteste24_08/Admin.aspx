<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="frontendteste24_08.Admin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <style>
        @import url('https://fonts.googleapis.com/css?family=Lato:200');


        .abadecima {
            background-color: black;
        }

        body {
            background-image: url(/imgs/preto.jpg);
            background: linear-gradient(75deg, rgba(2,6,56,1) 0%, rgba(1,4,41,1) 5%, rgba(0,2,22,1) 12%, rgba(0,0,0,1) 61%, rgba(0,0,0,1) 70%, rgba(0,4,54,1) 86%, rgba(0,3,51,1) 97%);
        }

        .fontedotitulo {
            color: white;
        }

        .iconpgamer {
            border-radius: 8px;
            font-family: broken
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
            border-image: 30 round;
        }


        .grid {
            color: white;
            background: linear-gradient(180deg, rgba(2,0,36,1) 0%, rgba(0,0,0,1) 3%, rgba(0,0,50,1) 71%);
            font-family: Console;
            font-size: 25px;
        }

        .botão {
            border-color: white;
            background: linear-gradient(100deg, rgba(113,113,136,1) 0%, rgba(0,0,42,1) 28%, rgba(0,0,42,1) 72%, rgba(113,113,136,1) 95%);
            font-family: 'Times New Roman', Times, serif;
            color: white;
            font-size: 28px;
        }
        .textbox {
            background-color: #000d1a;
            font-family: 'Times New Roman';
            color: white;
            font-size: 30px;
            border-color: white;
            border-style: solid;
            text-align: center;
        }

    </style>
     <div class="navbar navbar-inverse navbar-fixed-top abadecima" style="background-color: black">
        <div class="container">
            <div class="navbar-header">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
                <a class="navbar-brand" style="color: white; font-family: 'Lucida Console'" runat="server" href="~/">Computadores</a>
            </div>
            <div class="navbar-collapse collapse">
                <ul class="nav navbar-nav text-left">
                    <li style="color: white; font-family: 'Lucida Console'"><a runat="server" href="~/Loja">Produtos</a></li>
                    <li style="color: white; font-family: 'Lucida Console'"><a runat="server" href="~/ComponentesHomeOffice">Componentes</a></li>
                    <li style="color: white; font-family: 'Lucida Console'"><a runat="server" href="~/Login">Admin</a></li>
                </ul>
            </div>
        </div>
    </div>
    <br />
    <div class="jumbotron grid">

        <h1 class="text-center" style="color: white; font-family: Monaco">INFORMAÇÕES DA VENDA</h1>
        <asp:GridView runat="server" CssClass="GridView" ID="grdComponentes" Width="100%" AutoGenerateColumns="false" AllowPaging="false">
            <Columns>
                <asp:BoundField DataField="descricao" HeaderText="DESCRIÇÃO COMPONENTE" />
                <asp:BoundField DataField="tipo" HeaderText="TIPO" />
                <asp:BoundField DataField="comprar" HeaderText="COMPRAR" />
                <asp:BoundField DataField="gastos" HeaderText="GASTOS" />

            </Columns>
        </asp:GridView>
    </div>
  
<div class="no-print">
    <asp:TextBox runat="server" ID="valor_total" disabled="false" CssClass="textbox"></asp:TextBox>
    <asp:Button runat="server" ID="compra_realizada" Text="Realizar Compra" CssClass="botão" OnClick="compra_realizada_Click" />    
     <button type="button" value="imprimir" class="botão" onclick="window.print();" >Imprimir</button>
    </div>

</asp:Content>
