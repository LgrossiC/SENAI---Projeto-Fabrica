<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="frontendteste24_08.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <style>
        body /*Fundo da tela*/ {
            background: linear-gradient(50deg, rgba(15,19,27,1) 0%, rgba(5,26,69,1) 27%, rgba(4,25,42,1) 47%, rgba(0,0,0,1) 89%);
        }

        .textbox { /*Fundo da textbox dos componentes*/
            background-color: #000d1a;
            font-family: Cooperplate;
            color: white;
            font-size: 30px;
            border-color: white;
            border-style: solid;
            text-align: center;
        }

        .containerborda /*Borda branca do container*/ {
            border-style: solid;
            border-color: white;
        }

        .listas { /*Cor do fundo das listas*/
            background-color: #ffd9b3;
            color: white;
            font-family: 'Montserrat';
            background-color: #000d1a;
            font-size: 21px;
        }

        .nomeprodutos { /*Nome dos produtos que aparecem no começo da tela*/
            background: linear-gradient(185deg, rgba(0,0,0,1) 27%, rgba(2,0,33,1) 45%, rgba(1,0,22,1) 58%, rgba(49,47,87,1) 91%);
            color: white;
            font-family: 'Montserrat';
        }

        .fundopc {
            background-image: url(/newimgs/iconpc.jpg)
        }

        .fundojumbotron {
            background: linear-gradient(50deg, rgba(15,19,27,1) 0%, rgba(5,26,69,1) 27%, rgba(4,25,42,1) 47%, rgba(0,0,0,1) 89%);
        }

        .label {
            color: white;
            font-size: 30px;
        }

        .botão {
            border-color: white;
            background: linear-gradient(100deg, rgba(113,113,136,1) 0%, rgba(0,0,42,1) 28%, rgba(0,0,42,1) 72%, rgba(113,113,136,1) 95%);
            font-family: 'Times New Roman', Times, serif;
            color: white;
            font-size: 28px;
        }
    </style>

     <div class="navbar navbar-inverse navbar-fixed-top abadecima" style="background-color:black">
            <div class="container">
                <div class="navbar-header">
                    <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                    </button>
                    <a class="navbar-brand" style="color:white; font-family:'Lucida Console'" runat="server" href="~/">Computadores</a>
                </div>
                <div class="navbar-collapse collapse">
                    <ul class="nav navbar-nav text-left">
                        <li style="color:white; font-family:'Lucida Console'"><a runat="server" href="~/Loja">Produtos</a></li>
                        <li style="color:white; font-family:'Lucida Console'"><a runat="server" href="~/ComponentesHomeOffice">Componentes</a></li>
                        <li style="color:white; font-family:'Lucida Console'"><a runat="server" href="~/Login">Admin</a></li>
                    </ul>
                </div>
            </div>
    </div>
    
    <br />
    <br />
    <br />
    <br />

    <div class="row">

        <div class="col-sm-4"></div>
        <div class="col-sm-4">
            <div class="jumbotron fundojumbotron containerborda text-center">
                <h1 style="color: white; font-family: 'Montserrat';">LOGIN</h1>
                <br />
                <asp:Label ID="lbluser" runat="server" CssClass="label">Usuário: </asp:Label>
                <br>
                <asp:TextBox CssClass="textbox" ID="txtuser" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="lblsenha" CssClass="label" runat="server">Senha: </asp:Label>
                <br>
                <asp:TextBox CssClass="textbox" ID="txtsenha" TextMode="Password" runat="server"></asp:TextBox>
                <br>
                <br>
                <asp:Button ID="btnentrar" Text="Entrar" CssClass="btn botão" OnClick="btnentrar_Click" runat="server" />
            </div>
        </div>
        <div class="col-sm-4"></div>
    </div>
    <br /><br /><br /><br /><br /><br /><br /><br />
</asp:Content>

