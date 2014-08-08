<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ManageContact.aspx.cs" Inherits="Yero.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <table id="tblMain">
        <tr>
            <td>
     <table id="tblContact" style="background-color:aliceblue" >
        <tr>
                <td>
                    <asp:Label ID="lblContactHeading" runat="server" Text="Contact Profile Details" Font-Bold="True" Font-Size="Large"></asp:Label>
                </td>
            </tr>
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
                <asp:TextBox ID="txtUserName" runat="server" ReadOnly="true"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
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
        </table>
            </td>

        </tr>
        <tr>
            <td>
     <table id="tblAddress" style="background-color:aliceblue" >
            <tr>
                <td>
                    <asp:Label ID="lblAddressHeader" runat="server" Text="Contact Address Details" Font-Bold="True" Font-Size="Large"></asp:Label>
                </td>
            </tr>
             <tr>
                <td colspan="2">
                    <asp:Label ID="lblAddressID" runat="server" Visible="false"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                     <asp:Label ID="Label1" runat="server" Text="Address"></asp:Label>
                </td>

                <td>
                    <asp:TextBox ID="txtAddressLine1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <asp:TextBox ID="txtAddressLine2" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <asp:TextBox ID="txtAddressLine3" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblCounty" runat="server" Text="Country"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtCounty" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                     <asp:Label ID="lblAddressInfo" runat="server" Text="Address Info"></asp:Label>
                </td>
                <td>
                     <asp:TextBox ID="txtAddressInfo1" runat="server" ></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td></td>
                <td>
                     <asp:TextBox ID="txtAddressInfo2" runat="server"></asp:TextBox>
                </td>
            </tr>
             <tr>
            <td>
                <asp:Label ID="lblAddressAttention" runat="server" Text="Address Attention"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtAddressAttention" runat="server"></asp:TextBox>
            </td>
        </tr>
         <tr>
            <td>
                <asp:Label ID="lblPostalStreet" runat="server" Text="Address PO BOX / Street"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtPostalStreet" runat="server"></asp:TextBox>
            </td>
        </tr>
         <tr>
            <td>
                <asp:Label ID="lblCity" runat="server" Text="City"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
            </td>
        </tr>
         <tr>
            <td>
                <asp:Label ID="lblState" runat="server" Text="State"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtState" runat="server"></asp:TextBox>
            </td>
        </tr>
         <tr>
            <td>
                <asp:Label ID="lblPostalCode" runat="server" Text="Postal Code"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtPostalCode" runat="server"></asp:TextBox>
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
                <asp:Label ID="lblAddressType" runat="server" Text="Address Type"></asp:Label>
            </td>
            <td>
                <%--<asp:TextBox ID="txtAddressType" runat="server"></asp:TextBox>--%>
                <asp:DropDownList ID="ddAddressType" runat="server"></asp:DropDownList>
            </td>
        </tr>
        
        </table>
            </td>

        </tr>
        <tr>
            <td>
     <table id="tblPhone" style="background-color:aliceblue" >
        <tr>
                <td>
                    <asp:Label ID="LabelPhoneHeading" runat="server" Text="Contact Phone Details" Font-Bold="True" Font-Size="Large"></asp:Label>
                </td>
            </tr>
         <tr>
            <td colspan="2">
                <asp:Label ID="lblPhoneID" runat="server" Visible="false"></asp:Label>
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
                <%--<asp:TextBox ID="txtPhoneType" runat="server"></asp:TextBox>--%>
                <asp:DropDownList ID="ddPhoneType" runat="server"></asp:DropDownList>
            </td>
        </tr>
         </table>
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
