<%@ Page Language="C#"  MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Consumows.aspx.cs" Inherits="appTekStore.Consumows" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">
    <div class="row">
        <div class="col-md-6 col-md-offset-3">
            <form>
               <div  class="form-group">
        <asp:Label ID="Label1" runat="server" Text="Rut"></asp:Label>
    </div>
    <div  class="form-group">
        <asp:TextBox ID="TextBox1" runat="server" Width="100%" class="form-control form-control-lg"></asp:TextBox>
    </div>
    <div  class="form-group">
        <asp:Button ID="Button2" runat="server" class="btn btn-primary" Text="Consultar" OnClick="ConsultarConRut_FAbarca" />
    </div>

    <div>
        <asp:ListBox ID="ListBox1" runat="server" Width="100%" class="form-control" Height="108px">    
           

        </asp:ListBox>
    </div>
            </form>
        </div>
    </div>
</div>
    


</asp:Content>
