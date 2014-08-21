<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ManageOrder.aspx.cs" Inherits="Yero.ManageOrder" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Panel runat="server" ID="pnlProductSearch">
        <table id="tblSearchProduct">
            <tr>
                <td>
                    <asp:Label ID="lblProductName" runat="server" Text="Product Name"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtProductName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnSearchProduct" runat="server" Text="Search" OnClick="btnSearchProduct_Click" />
                </td>
            </tr>
        </table>
        <table id="tblSearchResult">
            <tr>
                <td>
                    <asp:GridView ID="grdProduct" runat="server"></asp:GridView>
                    <asp:Label ID="lblNoProducts" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
    </asp:Panel>

    <asp:Panel runat="server" ID="pnlManageOrder">
        <table id="tblManageOrder">
            <tr>
                <td>
                    <asp:DropDownList ID="ddProducts" runat="server"></asp:DropDownList>
                </td>
                <td>
                    <asp:TextBox ID="txtQuantity" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="btnAddToOrder" runat="server" Text="Add to Order" OnClick="btnAddToOrder_Click" />
                </td>
            </tr>
        </table>
    </asp:Panel>
    <asp:Panel runat="server" ID="pnlOrderDetails">
        <table>
            <tr>
                <td>
                    <asp:GridView ID="grdOrderDetails" runat="server"></asp:GridView>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblTotalAmountText" runat="server" Text="TotalAmount"></asp:Label>
                    <asp:Label ID="lblTotalAmount" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
    </asp:Panel>
</asp:Content>
