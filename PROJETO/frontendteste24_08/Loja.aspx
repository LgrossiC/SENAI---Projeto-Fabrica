<%@ Page Title="Loja" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Loja.aspx.cs" Inherits="frontendteste24_08.Loja" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <style>
        @import url('https://fonts.googleapis.com/css?family=Lato:200');

        body {  
            background-image: url(/imgs/preto.jpg);
            background: linear-gradient(50deg, rgba(15,19,27,1) 0%, rgba(5,26,69,1) 27%, rgba(4,25,42,1) 47%, rgba(0,0,0,1) 89%);
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
            border: 10px solid transparent;
        }

        .borderimage {
            border: 5px solid white;
        }
    </style>
<!--------------------------------------------------------------------------------------------------------------------------------------------------->

<!--JUMBOTRON DO TITULO-->
    <div class="jumbotron text-left fontedotitulo" style="background: radial-gradient(circle, rgba(2,0,36,1) 3%, rgba(7,6,33,1) 35%, rgba(0,0,29,1) 67%, rgba(0,16,41,1) 78%, rgba(5,56,93,1) 97%)";>
        <h1 style="font-family: Mauno">*Titulo do Pagina*</h1>
    </div>
<!--------------------------------------------------------------------------------------------------------------------------------------------------->
    <div class="jumbotron text-center" style="background: linear-gradient(50deg, rgba(15,19,27,1) 0%, rgba(5,26,69,1) 27%, rgba(4,25,42,1) 47%, rgba(0,0,0,1) 89%);">
        <div class="row">            
            
            <div class="col-lg-4">  <!--IMAGEM DO PC HOME-OFFICE-->
                <div class="row">
                    <div class="col-lg-4"></div>
                    <div class="col-lg-4">
                        <img src="newimgs/newiconpcgamer.png" height="100" width="150" class="iconpgamer" />
                    </div>
                    <div class="col-lg-4"></div>
                    <a href="ComponentesHomeOffice.aspx?id=3">
                        <asp:Image runat="server" ImageUrl="~/newimgs/setupgamer.jpg" Width="400" class="borderimage" Height="800" /></a>
                </div>
            </div>
<!--------------------------------------------------------------------------------------------------------------------------------------------------->
            <div class="col-lg-4">  <!--IMAGEM DO PC HOME-OFFICE-->
                <div class="row">
                    <div class="col-lg-4"></div>
                    <div class="col-lg-4">
                        <img src="newimgs/newiconpchomeoffice.png" height="100" width="150" class="iconpgamer" />
                    </div>
                    <div class="col-lg-4"></div>

                    <a href="ComponentesHomeOffice.aspx?id=2">
                        <asp:Image runat="server" ImageUrl="~/newimgs/setuphomeoffice.jpg" CssClass="borderimage" Width="400" Height="800" /></a>
                </div>
            </div>
<!--------------------------------------------------------------------------------------------------------------------------------------------------->
            <div class="col-lg-4">  <!--IMAGEM DO PC DE ESTUDAR-->               
                <div class="row">
                    <div class="col-lg-4"></div>
                    <div class="col-lg-4">
                        <img src="newimgs/newiconpcstudy.png" height="100" width="150" class="iconpgamer" />                        
                    </div>
                        <a href="ComponentesHomeOffice.aspx?id=1">
                        <asp:Image runat="server" ImageUrl="~/newimgs/studysetup.jpg" CssClass="borderimage" Width="400" Height="800" /></a>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
