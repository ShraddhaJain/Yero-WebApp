<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="SearchOrder.aspx.cs" Inherits="Yero.SearchOrder" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<table id="tblSearchCriteria" >
    <tr>
        <td>
            <asp:Label ID="lblOrderStatus" Text="Order Status" runat="server"></asp:Label>
        </td>
        <td>
            <asp:Label ID="lblOrderNumber" Text="Order Number" runat="server"></asp:Label>
        </td>
        <td>
            <asp:Label ID="lblOrderDate" Text="Order Date" runat="server"></asp:Label>
        </td>
        <td>
            <asp:Label ID="lblCustomerName" Text="Customer Name" runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            <asp:TextBox ID="txtOrderStatus" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtOrderNumber" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtOrderDate" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtCustomerName" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td colspan ="4" >
            <asp:Button ID="btnSearch" runat="server" Text="Search Order" OnClick="btnSearch_Click" />
        </td>
    </tr>
    
</table>

    <table id="tblSearchResult">
        <tr>
            <td>
                <asp:GridView ID="grdSearchResult" runat="server"></asp:GridView>
            </td>
        </tr>
    </table>




</asp:Content>
