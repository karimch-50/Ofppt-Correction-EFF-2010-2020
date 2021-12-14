<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Site1.Master" CodeBehind="Imprimer.aspx.vb" 
Inherits="var1_2011_asp.net.Imprimer" Title="Imprimer" %>

<%@ Register assembly="CrystalDecisions.Web, Version=10.5.3700.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" namespace="CrystalDecisions.Web" tagprefix="CR" %>
<asp:Content ID="Content1" ContentPlaceHolderID="main" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Numero de ligne: "></asp:Label>
&nbsp;<asp:TextBox ID="TextBox1" runat="server" 
    style="background-color: #CCFF99; color: #FFCC99;"></asp:TextBox>&nbsp;<asp:Button ID="Button1" runat="server" Text="Chercher" />
        <br />
        <CR:CrystalReportViewer ID="CrystalReportViewer2" runat="server" 
    AutoDataBind="true" />
        <CR:CrystalReportViewer ID="CrystalReportViewer1" runat="server" 
            AutoDataBind="true" Width="350px" />
        <br />
        <br />
    
</asp:Content>

