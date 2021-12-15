<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Connection.aspx.cs" Inherits="EFM_Rejional_ASP.Connection" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Login ID="Login1" runat="server" DisplayRememberMe="False" Height="174px" OnAuthenticate="Login1_Authenticate" Width="413px">
</asp:Login>
</asp:Content>
