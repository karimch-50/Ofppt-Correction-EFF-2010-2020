<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="MAJ_CONTRAT.aspx.cs" Inherits="EFM_Rejional_ASP.MAJ_CONTRAT" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridView1" runat="server" Width="317px" AutoGenerateColumns="False" OnRowCommand="GridView1_RowCommand">
        <Columns>
            <asp:BoundField HeaderText="NUM_CONTRAT" DataField="NUM_CONTRAT" />
            <asp:BoundField HeaderText="DATE_CONTRAT" DataField="DATE_CONTRAT" />
            <asp:BoundField HeaderText="NUM_BIEN" DataField="NUM_BIEN" />
            <asp:BoundField HeaderText="DUREE" DataField="DUREE" />
            <asp:ButtonField Text="Supprimer" CommandName="Supprimer" />
            <asp:ButtonField Text="Modifier" CommandName="Modifier" />
        </Columns>
    </asp:GridView>
    <asp:Label ID="Label2" runat="server" Text="DATE_CONTRAT" ></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server" TextMode="Date"></asp:TextBox>
    <br />
    <asp:Label ID="Label3" runat="server" Text="NUM_BIEN" ></asp:Label>
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label4" runat="server" Text="DUREE" ></asp:Label>
    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="Button1" runat="server" Text="Afficher" OnClick="Button1_Click" />
    <br />
    </asp:Content>
