<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Site1.Master" CodeBehind="Login.aspx.vb" 
Inherits="var1_2011_asp.net.Ligin" Title="LoginPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="main" runat="server">

        <asp:Label ID="Label1" runat="server" Text="Login :"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
            ControlToValidate="TextBox1" Display="Dynamic" ErrorMessage="Entrer un login"></asp:RequiredFieldValidator><br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Pass: "></asp:Label>
&nbsp;<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
            ControlToValidate="TextBox2" Display="Dynamic" 
            ErrorMessage="Entrer un password"></asp:RequiredFieldValidator><br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Connecter" />
        <br />
        <br />
        <asp:Label ID="Label3" runat="server"></asp:Label>
    
</asp:Content>
