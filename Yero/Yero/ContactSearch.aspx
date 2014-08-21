<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ContactSearch.aspx.cs" Inherits="Yero.ContactSearch" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<script lang="JavaScript">
    function Validate(sender, args) {
        var txt1 = document.getElementById("<%= txtEmail.ClientID %>");
      var txt2 = document.getElementById("<%= txtFname.ClientID%>");
        var txt3 = document.getElementById("<%= txtLname.ClientID%>");
        var txt4 = document.getElementById("<%= txtUserName.ClientID%>");
        args.IsValid = (txt1.value != "") || (txt2.value != "") || (txt3.value != "") || (txt4.value != "");
  }
</script>
<table id="tblSearchCriteria" >
    <tr>
        <td>
            <asp:Label ID="lblFName" Text="First Name" runat="server"></asp:Label>
        </td>
        <td>
            <asp:Label ID="lblLName" Text="Last Name" runat="server"></asp:Label>
        </td>
        <td>
            <asp:Label ID="lblUserName" Text="User Name" runat="server"></asp:Label>
        </td>
        <td>
            <asp:Label ID="lblEmail" Text="E-Mail" runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            <asp:TextBox ID="txtFname" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtLname" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td colspan ="4" >
            <asp:Button ID="btnSearch" runat="server" Text="Search Contact" OnClick="btnSearch_Click" />
        </td>
    </tr>
    <tr>
        <td colspan ="4">
            <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="Fill atlease one search criteria !!!" ClientValidationFunction="Validate" ValidateEmptyText="true" ForeColor="#FF3300"></asp:CustomValidator>
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
