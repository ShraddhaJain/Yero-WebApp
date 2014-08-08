<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ManageContactAddress.aspx.cs" Inherits="Yero.ManageContactAddress" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <table id="tblAddress">

        <tr>
            <td>
                <asp:Label ID="lblContactId" runat="server" Text="Contact ID"></asp:Label>
            </td>
            <td>
                <asp:Label ID="lblContactIdValue" runat="server"></asp:Label>
            </td>
        </tr>
         <tr>
            <td>
                <asp:Label ID="lblCountry" runat="server" Text="Country"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtCountry" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblArea" runat="server" Text="Area"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtArea" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblPhoneNumber" runat="server" Text="Phone Number"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtPhoneNumber" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblPhoneType" runat="server" Text="Phone Type"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtPhoneType" runat="server"></asp:TextBox>
            </td>
        </tr>
       

    </table>



</asp:Content>
