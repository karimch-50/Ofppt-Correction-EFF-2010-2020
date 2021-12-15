<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="TestWebService.aspx.cs" Inherits="EFM_Rejional_ASP.TestWebService" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="NUM_PROP"></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="Button1" runat="server" Text="Afficher" OnClick="Button1_Click" />
    <br />
<asp:GridView ID="GridView1" runat="server">
</asp:GridView>
    <br />
</asp:Content>
