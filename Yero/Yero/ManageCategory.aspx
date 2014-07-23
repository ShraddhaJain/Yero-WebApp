<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ManageCategory.aspx.cs"  MasterPageFile="~/Site1.Master" Inherits="Yero.ManageCategory" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <table id="tblContact" >
        <tr>
            <td>
                <asp:Label ID="lblCategoryId" runat="server" Text="Category ID"></asp:Label>
            </td>
            <td>
                <asp:Label ID="lblCategoryIdValue" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblCategoryname" runat="server" Text="Category Name"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtCategoryname" runat="server"></asp:TextBox>
            </td>
        </tr> 
        <tr>
            <td>
                <asp:Label ID="lblCategorydesc" runat="server" Text="Category Description"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtCategorydesc" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Button ID="btnAddCategory" runat="server" Text="Add Category" OnClick="btnAddCategory_Click" />
                <asp:Button ID="btnUpdateCategory" runat="server" Text="Update Category" OnClick="btnUpdateCategory_Click" />
                <asp:Button ID="btnDeleteCategory" runat="server" Text="Delete Category" OnClick="btnDeleteCategory_Click" />
            </td>
        </tr>
         </table>
</asp:Content>
