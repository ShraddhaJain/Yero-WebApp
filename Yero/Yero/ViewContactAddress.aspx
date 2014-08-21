<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ViewContactAddress.aspx.cs" Inherits="Yero.ViewContactAddress" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">


    <asp:GridView ID="grdAddress" runat="server" AutoGeneteColumns="False" AutoGenerateColumns="False" OnSelectedIndexChanged="grdAddress_SelectedIndexChanged" AutoGenerateSelectButton="True">
        <Columns>
            <asp:BoundField DataField="POST_ADD_ID" HeaderText="Address ID" NullDisplayText=" "/>
            <asp:BoundField DataField="CONT_ID" Visible="false" />
            <asp:BoundField DataField="POST_ADD_LINE_1" HeaderText="Address Line 1"  NullDisplayText=" " />
            <asp:BoundField DataField="POST_ADD_LINE_2" HeaderText="Address Line 2"  NullDisplayText=" "/>
            <asp:BoundField DataField="POST_ADD_LINE_3" HeaderText="Address Line 3"  NullDisplayText=" "/>
            <asp:BoundField DataField="POST_COUNTY" HeaderText="County"  NullDisplayText=" "/>
            <asp:BoundField DataField="POST_ADD_INFO_1" HeaderText="Info 1"  NullDisplayText=" "/>
            <asp:BoundField DataField="POST_ADD_INFO_2" HeaderText="Info 2"  NullDisplayText=" "/>
            <asp:BoundField DataField="POST_ADD_ATTN" HeaderText="Attention"  NullDisplayText=" "/>
            <asp:BoundField DataField="POST_ADD_PO_STREET" HeaderText="Postal Street"  NullDisplayText=" "/>
            <asp:BoundField DataField="POST_ADD_CITY" HeaderText="City"  NullDisplayText=" "/>
            <asp:BoundField DataField="POST_ADD_STATE" HeaderText="STATE"  NullDisplayText=" "/>
            <asp:BoundField DataField="POST_ADD_POSTAL_CODE" HeaderText="POSTAL CODE"  NullDisplayText=" "/>
            <asp:BoundField DataField="POST_ADD_COUNTRY" HeaderText="COUNTRY"  NullDisplayText=" "/>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:HiddenField ID="POST_ADD_TYPE" runat="server" Value='<%# Bind("POST_ADD_TYPE") %>' />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="Address_Type_name" HeaderText="Address Type"  NullDisplayText=" "/>
        </Columns>
    </asp:GridView>
    <asp:Label ID="lblUpdateDeletemsg" runat="server" Text="Select Address to update or delete !!!"></asp:Label>
    <asp:Label ID="lblNoAddressRecord" runat="server" Text="Address details does not exist."></asp:Label>

    <table>
        <tr>
            <td>
                <asp:Button ID="btnAddNewAddress" runat="server" Text="Add New Address" OnClick="btnAddNewAddress_Click" />
            </td>
        </tr>
    </table>

    <asp:Panel ID="pnlEditAddress" runat="server">
        <table id="tblResidentialAddress">
            <tr>
                <td colspan="2">
                    <asp:Label ID="lblAddressID" runat="server" Visible="false"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblAddressType" runat="server" Text="Address Type"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddAddressType" runat="server"></asp:DropDownList>
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
                    <asp:Label ID="lblCounty" runat="server" Text="County"></asp:Label>
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
                    <asp:TextBox ID="txtAddressInfo1" runat="server"></asp:TextBox>
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
                    <asp:Button ID="btnAddAddress" runat="server" Text="Add Address" OnClick="btnAddAddress_Click"  />
                    <asp:Button ID="btnUpdateAddress" runat="server" Text="Update Address" OnClick="btnUpdateAddress_Click" />
                    <asp:Button ID="btnDeleteAddress" runat="server" Text="Delete Address" OnClick="btnDeleteAddress_Click"/>
                </td>
            </tr>
        </table>
    </asp:Panel>
</asp:Content>
