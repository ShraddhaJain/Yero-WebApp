<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Welcome.aspx.cs" Inherits="Yero.Welcome" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    Welcome to Itivo application. 

    <table>
    <asp:Button Text="GetPermission" runat="server" OnClick="Unnamed1_Click" Visible="false"/>

    <asp:GridView ID="gridpermissions" runat="server" Visible="false"></asp:GridView>
    </table>

    
    <asp:Menu ID="Menu1" runat="server">
        <Items>
            <asp:MenuItem Text="Contact" NavigateUrl="~/ViewContact.aspx"></asp:MenuItem>
            <asp:MenuItem Text="Search Contact" NavigateUrl="~/ContactSearch.aspx"></asp:MenuItem>
            <asp:MenuItem Text="Categories" NavigateUrl="~/ViewCategory.aspx"></asp:MenuItem>
            <asp:MenuItem Text="Create Order" NavigateUrl="~/ManageOrder.aspx"></asp:MenuItem>
            <asp:MenuItem Text="Search Order" NavigateUrl="~/SearchOrder.aspx"></asp:MenuItem>
            <asp:MenuItem Text="Categories" NavigateUrl="~/ViewCategory.aspx"></asp:MenuItem>
        </Items>
        
    </asp:Menu>


</asp:Content>
