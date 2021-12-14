<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Site1.Master" CodeBehind="Question5.aspx.vb" Inherits="asp_var3_2012.Question5" 
    title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Repeater ID="Repeater1" runat="server">
    <HeaderTemplate><ul style="list-style-type:none;" ></HeaderTemplate>
    <ItemTemplate>
    <li style="display:inline;"> 
        <asp:HyperLink ID="HyperLink1"  runat="server" NavigateUrl='<%# Eval("lettre","~\Question5.aspx?lettre={0}") %>' Text='<%# Eval("lettre") %>'>
        </asp:HyperLink>
        </li>
    </ItemTemplate>
    <FooterTemplate></ul></FooterTemplate>         
    </asp:Repeater>
    <asp:Repeater ID="Repeater2" runat="server">
    <HeaderTemplate><ul style="list-style-type:none;" ></HeaderTemplate>
    <ItemTemplate>
    <li> 
        <asp:HyperLink ID="HyperLink1"  runat="server" 
        NavigateUrl='<%# String.Format("~\Question5.aspx?lettre={0}&id={1}", Eval("lettre"), Eval("idCirconscription")) %>' Text='<%# Eval("nomCir") %>'>
        </asp:HyperLink>
        </li>
    </ItemTemplate>
    <FooterTemplate></ul></FooterTemplate>         
    </asp:Repeater>
    <asp:Button ID="Button1" runat="server" Text="Button" Width="148px" />
    
    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>
    <table class="style1">
        <tr>
            <td>
                <asp:Button ID="Button2" runat="server" Text="Generer XML" Width="169px" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
&nbsp;<br />
</asp:Content>
