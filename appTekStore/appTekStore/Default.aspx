<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="appTekStore._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <form>
         <div  class="container">
        
        <div  class="form-group">
            <asp:Label ID="Label1" runat="server" Text="Nombre"></asp:Label>
        </div>
        <div class="form-group">
            <asp:TextBox ID="TextBox1" runat="server" class="form-control form-control-lg"></asp:TextBox>
        </div>

        <div  class="form-group">
            <asp:Label ID="Label2" runat="server" Text="Rut"></asp:Label>
        </div>
        <div  class="form-group" >
            <asp:TextBox ID="TextBox2" runat="server"  class="form-control form-control-lg"></asp:TextBox>
        </div>

        <div  class="form-group">
            <asp:Label ID="Label3" runat="server" Text="Dirección"></asp:Label>
        </div>
        <div  class="form-group">
            <asp:TextBox ID="TextBox3" runat="server" class="form-control form-control-lg"></asp:TextBox>
        </div>


             <div  class="form-group">
            <asp:Label ID="Label4" runat="server" Text="Teléfono"></asp:Label>
        </div>
        <div  class="form-group">
            <asp:TextBox ID="TextBox4" runat="server" class="form-control form-control-lg"></asp:TextBox>
        </div>

               <div  class="form-group">
            <asp:Label ID="Label5" runat="server" Text="Productos"></asp:Label>
        </div>
        <div  class="form-group" >
                <div class="dropdown">
                    <asp:DropDownList   ID="DropDownList1" runat="server" Height="43px" Width="100%"></asp:DropDownList>
                </div>
            </div>



               <div  class="form-group">
            <asp:Label ID="Label6" runat="server" Text="Cantidad"></asp:Label>
        </div>
        <div  class="form-group">
            <asp:TextBox ID="TextBox6" runat="server" class="form-control form-control-lg"></asp:TextBox>
        </div>
           

        <div class="form-group">
            <asp:Button ID="Button1" runat="server" Text="Ingresar" class="btn btn-primary" Height="51px" Width="124px" />
        </div>

       
    </div>

         </form> 
    
 
</asp:Content>
