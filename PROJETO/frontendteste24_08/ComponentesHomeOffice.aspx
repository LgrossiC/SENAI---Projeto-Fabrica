<%@ Page Title="ComponentesHomeOffice" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ComponentesHomeOffice.aspx.cs" Inherits="frontendteste24_08.ComponentesHomeOffice" %>

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
    </style>

    <!----------------------------------------------------------------------------------------------------------------->
    <!--PRIMEIRA JUMBOTRON DA TELA-->
    <div class="jumbotron containerborda text-center" style="background-color: #001133; background-image: url(/newimgs/azulescuro.jpg)">
        <div class="row">
            <div class="col-sm-8 text-center">
                <h1 style="color: white; font-family:'Copperplate'">CONFIRA NOSSOS PRODUTOS</h1>
                <br />

                <br />               

            </div>
            <div class="col-sm-4">
                <!--Imagem que ficará na direita da primeira jumbotron (Ainda não colocada)-->
            </div>
        </div>
    </div>
    <!------------------------------------------------------------------------------------------------------------------------------------------------------------>

    <!-------2ª Jumbotron da tela-------------------------------------------------------------------------------------------------------------------------------------->

    <div class="jumbotron containerborda fundojumbotron">

        <div class="row">
            <div class="col-sm-4 text-center">
                <asp:TextBox runat="server" ID="txtPlacaMae" Text="Placa Mãe" Enabled="false" CssClass="textbox"></asp:TextBox>
                <br />
                <br />
                <asp:TextBox runat="server" ID="txtProcessador" Text="Processador" Enabled="false" CssClass="textbox"></asp:TextBox>
                <br />
                <br />
                <asp:TextBox runat="server" ID="txtFonte" Text="Fonte" Enabled="false" CssClass="textbox"></asp:TextBox>
                <br />
                <br />
                <asp:TextBox runat="server" ID="txtArmazenamento" Text="Armazenamento" Enabled="false" CssClass="textbox"></asp:TextBox>
                <br />
                <br />
                <asp:TextBox runat="server" ID="txtRAM" Text="RAM" Enabled="false" CssClass="textbox"></asp:TextBox>
                <br />
                <br />
                <br />
                <asp:TextBox runat="server" ID="txtGabinete" Text="Gabinete" Enabled="false" CssClass="textbox"></asp:TextBox>
                <br />
                <br />
                <br />
                <asp:TextBox runat="server" ID="txtPlacaVideo" Text="Placa de Vídeo" Enabled="false" CssClass="textbox"></asp:TextBox>
                <br />
                <br />
                <br />

                <asp:TextBox runat="server" ID="txtSaidaSom" Text="Saída de Som" Enabled="false" CssClass="textbox"></asp:TextBox>
                </div>
                 
               
               <div class="col-sm-2 text-center" style="padding-top:5px">
                   <asp:DropDownList runat="server" ID="ListPlacaMãe" OnSelectedIndexChanged="ListPlacaMãe_SelectedIndexChanged" AutoPostBack="true" CssClass="form-control listas" Height="45px">
                   </asp:DropDownList>
                   <br />
                   <asp:DropDownList runat="server" ID="ListProcessador" OnSelectedIndexChanged="ListProcessador_SelectedIndexChanged" AutoPostBack="true" CssClass="form-control listas"></asp:DropDownList>
                   <br /><br />
                   <asp:DropDownList runat="server" ID="ListFonte" OnSelectedIndexChanged="ListFonte_SelectedIndexChanged" AutoPostBack="true" CssClass="form-control listas"></asp:DropDownList>
                   <br /><br />
                   <asp:DropDownList runat="server" ID="ListArmazenamento" OnSelectedIndexChanged="ListArmazenamento_SelectedIndexChanged" AutoPostBack="true" CssClass="form-control listas"></asp:DropDownList>
                   <br /><br />
                   <asp:DropDownList runat="server" ID="ListRAM" OnSelectedIndexChanged="ListRAM_SelectedIndexChanged" AutoPostBack="true" CssClass="form-control listas"></asp:DropDownList>
                   <br /><br />
                   <asp:DropDownList runat="server" ID="ListGabinete" OnSelectedIndexChanged="ListGabinete_SelectedIndexChanged" AutoPostBack="true" CssClass="form-control listas"></asp:DropDownList>
                   <br /><br /><br />
                   <asp:DropDownList runat="server" ID="ListPlacaVideo" OnSelectedIndexChanged="ListPlacaVideo_SelectedIndexChanged" AutoPostBack="true" CssClass="form-control listas"></asp:DropDownList>
                   <br /><br />                   
                   <asp:DropDownList runat="server" ID="ListSaídaSom" OnSelectedIndexChanged="ListSaídaSom_SelectedIndexChanged" AutoPostBack="true" CssClass="form-control listas"></asp:DropDownList>
               </div>

               <div class="col-sm-4 text-center" style="padding-top:5px">
                   <asp:TextBox runat="server" ID="txtValorPlacaMae" Enabled="false" CssClass="textbox" ></asp:TextBox>

                   <br /><br />
                   
                   <asp:TextBox runat="server" ID="txtValorProcessador" Enabled="false" CssClass="textbox"></asp:TextBox>
                   <br /><br />                   

                   <asp:TextBox runat="server" ID="txtValorFonte" Enabled="false" CssClass="textbox"></asp:TextBox>
                   <br /><br />
                   
                   <asp:TextBox runat="server" ID="txtValorArmazenamento" Enabled="false" CssClass="textbox"></asp:TextBox>
                   <br /><br />
                   
                   <asp:TextBox runat="server" ID="txtValorRAM" Enabled="false" CssClass="textbox"></asp:TextBox>
                   <br /><br /><br />
                   
                   <asp:TextBox runat="server" ID="txtValorGabinete" Enabled="false" CssClass="textbox"></asp:TextBox>
                   <br /><br /><br />
                   
                   <asp:TextBox runat="server" ID="txtValorPlacaVideo" Enabled="false" CssClass="textbox"></asp:TextBox>
                   <br /><br /><br />
                   
                   <asp:TextBox runat="server" ID="txtValorSaidaSom" Enabled="false" CssClass="textbox"></asp:TextBox>                   
               </div>

        
             <div class="row">


            <div class="col-sm-2 text-center" style="padding-top: 5px">
                                    
        <asp:Button runat="server" ID="btnFinalizarVenda" Text="Finalizar Venda" OnClick="btnFinalizarVenda_Click" CssClass="btn btn-success" />

        <asp:Button runat="server" ID="btnQuantidadeMais" Text="+" OnClick="btnQuantidadeMais_Click" CssClass="btn btn-success" />
        <asp:Button runat="server" ID="btnQuantidadeMenos" Text="-" OnClick="btnQuantidadeMenos_Click" CssClass="btn btn-danger" />
        <br /><br />
        <asp:TextBox runat="server" ID="txtMostrarQuantidade" CssClass="textbox" Text="1"></asp:TextBox>
        <br />
         <p> Nome do Usuário</p>


         <asp:TextBox runat="server" ID="NomeUsuario" CssClass="textbox"></asp:TextBox>       
            </div>
        <asp:Button runat="server" ID="btnQuantidade" Text="+" OnClick="btnQuantidade_Click" CssClass="btn btn-success" />
        </div>
<!------------------------------------------------------------------------------------------------------------------------->          
           </div>    
        </div>
        
        

    <!------------------------------------------------------------------------------------------------------------------------->


</asp:Content>
