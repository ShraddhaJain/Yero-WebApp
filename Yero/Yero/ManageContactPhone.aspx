<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ManageContactPhone.aspx.cs" Inherits="Yero.ManageContactPhone" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <table id="tblPhone">
        
         <tr>
            <td>
                <asp:Label ID="lblPhoneId" runat="server" Text="Phone ID"></asp:Label>
            </td>
            <td>
                <asp:Label ID="lblPhoneIDValue" runat="server" ></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblPhoneCountry" runat="server" Text="Country"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtPhoneCountry" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblPhoneArea" runat="server" Text="Area"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtPhoneArea" runat="server"></asp:TextBox>
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
        <tr>
            <td colspan="2" style="align-content:center">
                <asp:Button ID="btnAddPhone" runat="server" Text="Add Contact Phone" OnClick="btnAddContactPhone_Click" />
                <asp:Button ID="btnUpdatePhone" runat="server" Text="Update Contact Phone" OnClick="btnUpdateContactPhone_Click" style="height: 26px" />
                <asp:Button ID="btnDeletePhone" runat="server" Text="Delete Contact Phone" OnClick="btnDeleteContactPhone_Click" />
            </td>
        </tr>
    </table>
</asp:Content>
