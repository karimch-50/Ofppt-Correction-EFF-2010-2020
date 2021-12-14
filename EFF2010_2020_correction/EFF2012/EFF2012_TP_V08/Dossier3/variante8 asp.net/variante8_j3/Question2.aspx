<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Site1.Master" CodeBehind="Question2.aspx.vb" Inherits="variante8_j3.WebForm1" 
    title="Page sans titre" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="width:100%;">
    <asp:Login ID="Login1" runat="server">
    </asp:Login>
    
    
        <br />
        <asp:Panel ID="Panel1" runat="server">
            <asp:Label ID="Label1" runat="server" Text="Votre Véhicule : "></asp:Label>
            <br />
            <asp:GridView ID="Grid_Vehicule" runat="server">
            </asp:GridView>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Pannes :"></asp:Label>
            <br />
            <asp:GridView ID="Grid_Pannes" runat="server">
            </asp:GridView>
        </asp:Panel>
    
    
    </div>
    
</asp:Content>
