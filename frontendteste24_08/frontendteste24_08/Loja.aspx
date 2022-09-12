<%@ Page Title="Loja" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Loja.aspx.cs" Inherits="frontendteste24_08.Loja" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <style>
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
