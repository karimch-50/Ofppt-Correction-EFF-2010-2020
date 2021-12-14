<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Site1.Master" CodeBehind="Question3.aspx.vb" Inherits="variante8_j3.WebForm2" 
    title="Page sans titre" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="width:100%;">
        
        <br />
        <asp:Label ID="Label1" runat="server" Text="Vehicules Actuelement en Panne : "></asp:Label>
        <br />
        <asp:GridView ID="GridView1" runat="server">
            <Columns>
                <asp:TemplateField HeaderText="Selectionner">
                    <EditItemTemplate>
                        <asp:CheckBox ID="CheckBox1" runat="server" />
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:CheckBox ID="CheckBox1" runat="server" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <br />
        <asp:LinkButton ID="LinkButton1" runat="server">Realiser</asp:LinkButton>
        
    </div>
</asp:Content>
