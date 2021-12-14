<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Site1.Master" CodeBehind="Q3.aspx.vb" Inherits="v7_2012.WebForm4" 
    title="Page sans titre" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True">
    </asp:DropDownList>
    <br />
</p>
<p>
    <asp:GridView ID="GridView1" runat="server">
        <Columns>
            <asp:TemplateField>
                <EditItemTemplate>
                    <asp:CheckBox ID="CheckBox1" runat="server" />
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:CheckBox ID="CheckBox1" runat="server" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</p>
<p>
    Montant total :
    <asp:Label ID="Label1" runat="server"></asp:Label>
</p>
<p>
    <asp:LinkButton ID="LinkButton3" runat="server">constituer</asp:LinkButton>
</p>
<p>
</p>
</asp:Content>
