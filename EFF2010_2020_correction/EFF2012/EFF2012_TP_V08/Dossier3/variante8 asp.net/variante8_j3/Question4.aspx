<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Site1.Master" CodeBehind="Question4.aspx.vb" Inherits="variante8_j3.WebForm3" 
    title="Page sans titre" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            width: 94px;
        }
        .style3
        {
            width: 128px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="width:100%;"> 
        
        <table class="style1">
            <tr>
                <td class="style2">
                    <asp:Label ID="Label1" Text="ID Accident :" runat="server" ></asp:Label>
                </td>
                <td class="style3">
                    <asp:TextBox ID="txtb_IDAcc" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ErrorMessage="Saisir L'Id De L'accident" text="*">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    <asp:Label ID="Label2" Text="Date Accident :" runat="server" ></asp:Label>
                </td>
                <td class="style3">
                    <asp:TextBox ID="txtb_Date" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                        ErrorMessage="Saisir la date  De L'accident" text="*">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    <asp:Label ID="Label3" runat="server" Text="Note :" ></asp:Label>
                </td>
                <td class="style3">
                    <asp:TextBox ID="txtb_Note" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                        ErrorMessage="Saisir La note De L'accident" text="*">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    <asp:Label ID="Label4" Text="Vehicule :"  runat="server" ></asp:Label>
                </td>
                <td class="style3">
                    <asp:DropDownList ID="cmb_Vehicule" runat="server">
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                        ErrorMessage="selectionner le véhicule" text="*">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    &nbsp;</td>
                <td class="style3">
                    <asp:Button ID="Button1" runat="server" Text="Ajouter" Width="127px" />
                &nbsp;
                    <asp:Button ID="Button2" runat="server" Text="Supprimer" Width="127px" />
                    <br />
                    <asp:Button ID="Button3" runat="server" Text="Modifier" Width="127px" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style2">
                    &nbsp;</td>
                <td class="style3">
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
        
    </div>

</asp:Content>
