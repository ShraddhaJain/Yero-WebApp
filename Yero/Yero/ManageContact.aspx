<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ManageContact.aspx.cs" Inherits="Yero.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <table id="tblContact" >
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
                <asp:Label ID="lblFname" runat="server" Text="First Name"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtFname" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblMname" runat="server" Text="Middle Name"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtMname" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblLname" runat="server" Text="Last Name"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtLname" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblUserName" runat="server" Text="UserName"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblSecurityQue" runat="server" Text="Security Question?"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtSecurityQue" runat="server" ></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblSecurityAns" runat="server" Text="Security Answer"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtSecurityAns" runat="server" ></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblOrderNo" runat="server" Text="Order Number"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtOrderNo" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblSkypeid" runat="server" Text="Skype Id"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtSkypeId" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblFacebookId" runat="server" Text="Facebook Id"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtFacebookId" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblLinkedinId" runat="server" Text="Linkedin Id"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtLinkedinId" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblTwittetId" runat="server" Text="Twitter Id"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtTwitterId" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblGoogleplusId" runat="server" Text="Google Plus Id"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtGoogleplusId" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblLink1Id" runat="server" Text="Link Id 1"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtLink1Id" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblLink2Id" runat="server" Text="Link Id 2"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtLink2Id" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblLink3Id" runat="server" Text="Link Id 3"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtLink3Id" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblBlogId" runat="server" Text="BLOG Id"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtBlogId" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblWebsiteUrl" runat="server" Text="Website URL"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtWebsiteUrl" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2" style="align-content:center">
                <asp:Button ID="btnAddContact" runat="server" Text="Add Contact" OnClick="btnAddContact_Click" />
                <asp:Button ID="btnUpdateContact" runat="server" Text="Update Contact" OnClick="btnUpdateContact_Click" style="height: 26px" />
                <asp:Button ID="btnDeleteContact" runat="server" Text="Delete Contact" OnClick="btnDeleteContact_Click" />
            </td>
        </tr>
        </table>
</asp:Content>
