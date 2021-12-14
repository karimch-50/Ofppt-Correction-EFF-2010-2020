<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Site1.Master" CodeBehind="DisplayXML.aspx.vb" 
Inherits="var1_2011_asp.net.DisplayXML" Title="display xml" %>
<asp:Content ID="Content1" ContentPlaceHolderID="main" runat="server">
<asp:Button ID="Button1" runat="server" Text="Afficher page xml avec xslt" 
            onClientClick="document.getElementById('HiddenField1').value = document.getElementById('FileUpload1').value" 
            Width="232px"/>
        <br />
        <br />
        <asp:Xml ID="Xml1" runat="server"></asp:Xml>
        <br />
        <br />
</asp:Content>

