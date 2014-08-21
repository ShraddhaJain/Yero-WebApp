<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ManageContact.aspx.cs" Inherits="Yero.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <table id="tblMain">
        <tr>
            <td>
                <table id="tblContact" style="background-color: aliceblue">
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
                            <asp:TextBox ID="txtSecurityQue" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblSecurityAns" runat="server" Text="Security Answer"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtSecurityAns" runat="server"></asp:TextBox>
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
                <asp:Button ID="btnManageAddress"  runat="server" Text="Contact Address" OnClick="btnManageAddress_Click" />
                <asp:Button ID="btnManagePhone" runat="server" Text="Contact Phone" OnClick="btnManagePhone_Click" />
            </td>
        </tr>
        
        <tr>
            <td>
                <table id="tblAddress" style="background-color: aliceblue" hidden="hidden">
                    <tr>
                        <td>
                            <asp:Label ID="lblAddressHeader" runat="server" Text="Contact Address Details" Font-Bold="True" Font-Size="Large"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <table id="tblResidentialAddress">
                                <tr>
                                    <td colspan="2">
                                        <asp:Label ID="lblResidentialAddress" runat="server" Text="Residential Address"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="2">
                                        <asp:Label ID="lblRAAddressID" runat="server" Visible="false"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="Label1" runat="server" Text="Address"></asp:Label>
                                    </td>

                                    <td>
                                        <asp:TextBox ID="txtRAAddressLine1" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td></td>
                                    <td>
                                        <asp:TextBox ID="txtRAAddressLine2" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td></td>
                                    <td>
                                        <asp:TextBox ID="txtRAAddressLine3" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="lblRACounty" runat="server" Text="Country"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtRACounty" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="lblRAAddressInfo" runat="server" Text="Address Info"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtRAAddressInfo1" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td></td>
                                    <td>
                                        <asp:TextBox ID="txtRAAddressInfo2" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="lblRAAddressAttention" runat="server" Text="Address Attention"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtRAAddressAttention" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="lblRAPostalStreet" runat="server" Text="Address PO BOX / Street"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtRAPostalStreet" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="lblRACity" runat="server" Text="City"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtRACity" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="lblRAState" runat="server" Text="State"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtRAState" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="lblRAPostalCode" runat="server" Text="Postal Code"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtRAPostalCode" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="lblRACountry" runat="server" Text="Country"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtRACountry" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                            </table>
                        </td>
                        <td>
                            <table id="tblPostalAddress">
                                <tr>
                                    <td colspan="2">
                                        <asp:Label ID="lblPostalAddress" runat="server" Text="Postal Address"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="2">
                                        <asp:Label ID="lblPAAddressID" runat="server" Visible="false"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="Label6" runat="server" Text="Address"></asp:Label>
                                    </td>

                                    <td>
                                        <asp:TextBox ID="txtPAAddressLine1" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td></td>
                                    <td>
                                        <asp:TextBox ID="txtPAAddressLine2" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td></td>
                                    <td>
                                        <asp:TextBox ID="txtPAAddressLine3" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="lblPACounty" runat="server" Text="Country"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtPACounty" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="lblPAAddressInfo" runat="server" Text="Address Info"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtPAAddressInfo1" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td></td>
                                    <td>
                                        <asp:TextBox ID="txtPAAddressInfo2" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="lblPAAddressAttention" runat="server" Text="Address Attention"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtPAAddressAttention" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="lblPAPostalStreet" runat="server" Text="Address PO BOX / Street"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtPAPostalStreet" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="lblPACity" runat="server" Text="City"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtPACity" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="lblPAState" runat="server" Text="State"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtPAState" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="lblPAPostalCode" runat="server" Text="Postal Code"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtPAPostalCode" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="lblPACountry" runat="server" Text="Country"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtPACountry" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
            </td>

        </tr>
        <tr>
            <td>
                <table id="tblPhone" style="background-color: aliceblue"  hidden="hidden">
                    <tr>
                        <td>
                            <asp:Label ID="LabelPhoneHeading" runat="server" Text="Phone Details" Font-Bold="True" Font-Size="Large"></asp:Label>
                        </td>
                    </tr>

                    <tr>
                        <td>
                            <table id="tblMobilePhone">
                                <tr>
                                    <td colspan="2">
                                        <asp:Label ID="lblMobilePhoneID" runat="server" Visible="false"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="lblMobile" runat="server" Text="Mobile"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="lblMPPhoneCountry" runat="server" Text="Country"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtMPPhoneCountry" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="lblMPPhoneArea" runat="server" Text="Area"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtMPPhoneArea" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="lblMPPhoneNumber" runat="server" Text="Phone Number"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtMPPhoneNumber" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                            </table>
                        </td>
                        <td>
                            <table id="tblOfficePhone">
                                <tr>
                                    <td colspan="2">
                                        <asp:Label ID="lblOfficePhoneID" runat="server" Visible="false"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="lblOfficePhone" runat="server" Text="Office Phone"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="lblOPPhoneCountry" runat="server" Text="Country"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtOPPhoneCountry" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="lblOPPhoneArea" runat="server" Text="Area"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtOPPhoneArea" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="lblOPPhoneNumber" runat="server" Text="Phone Number"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtOPPhoneNumber" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                            </table>
                        </td>
                        <td>
                            <table id="tblHomePhone">
                                <tr>
                                    <td colspan="2">
                                        <asp:Label ID="lblHomePhoneID" runat="server" Visible="false"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="lblHomePhone" runat="server" Text="Home Phone"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="lblHPPhoneCountry" runat="server" Text="Country"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtHPPhoneCountry" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="lblHPPhoneArea" runat="server" Text="Area"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtHPPhoneArea" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="lblHPPhoneNumber" runat="server" Text="Phone Number"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtHPPhoneNumber" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>

            </td>
        </tr>
        <tr>
            <td colspan="2" style="align-content: center">
                <asp:Button ID="btnUpdateContact" runat="server" Text="Update Contact" OnClick="btnUpdateContact_Click" Style="height: 26px" />
                <asp:Button ID="btnDeleteContact" runat="server" Text="Delete Contact" OnClick="btnDeleteContact_Click" />
            </td>
        </tr>
    </table>
</asp:Content>
