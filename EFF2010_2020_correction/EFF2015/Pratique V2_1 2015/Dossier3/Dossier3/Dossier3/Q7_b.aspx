<%@ Page Title="" Language="C#" MasterPageFile="~/Q2.Master" AutoEventWireup="true" CodeBehind="Q7_b.aspx.cs" Inherits="Dossier3.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style1
        {
            width: 337px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width:100%;">
        <tr>
            <td class="style1">
                id Abonnement :</td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server" Width="142px"></asp:TextBox>
                <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Afficher" 
                    Width="70px" />
            </td>
        </tr>
        <tr>
            <td class="style1">
                <asp:Label ID="Label1" runat="server" Text="valeur Maximum des consomation :"></asp:Label>
            </td>
            <td>
                <asp:Label ID="lblMax" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
