<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ViewPhone.aspx.cs" Inherits="Yero.ViewPhone" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">


    <asp:GridView ID="grdPhone" runat="server" AutoGenerateColumns="False" AutoGenerateSelectButton="True" OnSelectedIndexChanged="grdPhone_SelectedIndexChanged" >
        <Columns>
            <asp:BoundField DataField="PHONE_ID" HeaderText="Phone ID" />
            <asp:BoundField DataField="CONT_ID" Visible="false" />
            <asp:BoundField DataField="Contact_Phone_ID" Visible="false" />
            <asp:BoundField DataField="PHONE_COUNTRY" HeaderText="Phone Country" />
            <asp:BoundField DataField="PHONE_AREA" HeaderText="Phone Area" />
            <asp:BoundField DataField="PHONE_NUMBER" HeaderText="Phone Number" />
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:HiddenField ID="PHONE_TYPE" runat="server" Value='<%# Bind("PHONE_TYPE") %>' />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="Phone_Type_name" HeaderText="Phone Type" />
        </Columns>

    </asp:GridView>
    <asp:Label ID="lblUpdateDeletemsg" runat="server" Text="Select Phone record to update or delete !!!"></asp:Label>
    <asp:Label ID="lblNoPhoneRecord" runat="server" Text="Phone details does not exist."></asp:Label>

    <table>
        <tr>
            <td>
                <asp:Button ID="btnAddNewPhone" runat="server" Text="Add New Phone" OnClick="btnAddNewPhone_Click" />
            </td>
        </tr>
    </table>

    <asp:Panel ID="pnlEditPhone" runat="server">

        <table id="tblEditPhone">
            <tr>
                <td colspan="2">
                    <asp:Label ID="lblPhoneID" runat="server" Visible="false"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblPhoneType" runat="server" Text="Phone Type"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddPhoneType" runat="server"></asp:DropDownList>
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
                    <asp:Button ID="btnAddPhone" runat="server" Text="Add Phone" OnClick="btnAddPhone_Click" />
                    <asp:Button ID="btnUpdatePhone" runat="server" Text="Update Phone" OnClick="btnUpdatePhone_Click" />
                    <asp:Button ID="btnDeletePhone" runat="server" Text="Delete Phone" OnClick="btnDeletePhone_Click" />
                </td>
            </tr>
        </table>
    </asp:Panel>


</asp:Content>
