<%@ Page Title="Loja" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Loja.aspx.cs" Inherits="frontendteste24_08.Loja" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <style>
<<<<<<< HEAD
        body{background-image:url(/imgs/preto.jpg)}
       
    </style>          
        
    
    <div class="jumbotron text-center" style="background-color:#fca311;padding-bottom:1px;padding-top:1px; padding-right:3px; padding-left:3px">
        <div class="jumbotron" style="background-color:black">
        <div class="row">
            <div class="col-sm-4">
                icon1
                <br />
            </div>
            <div class="col-sm-4">
                icon2
                <br />
            </div>
            <div class="col-sm-4">
                icon 3
                <br />
=======
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
           border-image:30 round
        }
    </style>
<!--------------------------------------------------------------------------------------------------------------------------------------------------->
    <div class="navbar navbar-inverse navbar-fixed-top abadecima">
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
                        <li style="color:white; font-family:'Lucida Console'"><a runat="server" href="~/Admin">Admin</a></li>
                    </ul>
                </div>
            </div>
    </div>


<!--JUMBOTRON DO TITULO-->
    <div class="jumbotron text-left fontedotitulo" style="background-image: url(/newimgs/azulescuro.jpg);">
        <h1 style="font-family: Mauno">StorageComputers</h1>
    </div>
<!--------------------------------------------------------------------------------------------------------------------------------------------------->
    
    
    <div class="jumbotron text-center" style="background: linear-gradient(75deg, rgba(2,6,56,1) 0%, rgba(1,4,41,1) 5%, rgba(0,2,22,1) 12%, rgba(0,0,0,1) 61%, rgba(0,0,0,1) 70%, rgba(0,4,54,1) 86%, rgba(0,3,51,1) 97%);">
        <div class="row">            
            
            <div class="col-lg-4">  <!--IMAGEM DO PC HOME-OFFICE-->
                <div class="row">
                    <div class="col-lg-4"></div>
                    <div class="col-lg-4">  
                        <img src="newimgs/iconpcgamer3.png" height="100" width="150" class="iconpgamer" />
                    </div>
                    <div class="col-lg-4"></div>
                    <a href="ComponentesHomeOffice.aspx?id=3">
                        <asp:Image runat="server" ImageUrl="~/newimgs/pcgamer1.jpg" Width="400" class="borderimage" Height="800" /></a>
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
                        <asp:Image runat="server" ImageUrl="~/newimgs/pchomeoffice1.jpg" CssClass="borderimage" Width="400" Height="800" /></a>
                </div>
            </div>
<!--------------------------------------------------------------------------------------------------------------------------------------------------->
            <div class="col-lg-4">  <!--IMAGEM DO PC DE ESTUDAR-->               
                <div class="row">
                    <div class="col-lg-4"></div>
                    <div class="col-lg-4">
                        <img src="newimgs/newiconpcstudy.png" height="100" width="150" class="iconpgamer" />                        
                    </div>
                        <a href="ComponentesHomeOffice.aspx?id=1" class="borderimage">
                        <asp:Image runat="server" ImageUrl="~/newimgs/pcstudy1.jpg"  Width="400" Height="800" /></a>
                </div>
>>>>>>> 21f1cad9cdc667f5f7966433e035d77456149cca
            </div>
        </div>
        </div>
    </div>
                       
    <div class="jumbotron text-center" style="background-color:black">
            <div class="row">

            <div class="col-lg-4">
                <br />
                <div class="container" style="background-color:#000000">
                <a href ="ComponentesHomeOffice.aspx?id=3"><asp:image runat="server" imageurl="~/imgs/setup1.jpg" Width="400" BorderColor="Coral" Height="800"/></a>
            </div>
                </div>
            
            <div class="col-sm-4">
                <br />
                <div class="container" style="background-color:#000000">
                <a href ="ComponentesHomeOffice.aspx?id=2"><asp:image runat="server" imageurl="~/imgs/imgPCGAMER.png" Width="400" Height="800"/></a>
            </div>
                </div>
                <div class="col-sm-4">
                    <br />
                    <div class="container" style="background-color:#000000">
                        <a href ="ComponentesHomeOffice.aspx?id=1"><asp:image runat="server" imageurl="~/imgs/imgPCGAMER.png" Width="400" Height="800"/></a>
                    </div>
                </div>
            </div>
    </div>
                        
    

</asp:Content>
