﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewContact.aspx.cs" MasterPageFile="~/Site1.Master"  Inherits="Yero.ViewContact" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <table id="tblContactgrid">
        <tr>
            <td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <asp:GridView ID="grdContact" runat="server" AutoGenerateColumns="false" OnSelectedIndexChanged="grdContact_SelectedIndexChanged" AutoGenerateSelectButton="true">
                    <Columns >
                        <asp:BoundField DataField="CONT_ID" HeaderText="ID" />
                        <asp:BoundField DataField="CONT_F_Name" HeaderText="First Name" />
                        <asp:BoundField DataField="CONT_M_Name" HeaderText="Middle Name" />
                        <asp:BoundField DataField="CONT_L_Name" HeaderText="Last Name" />
                    </Columns>
                    <SelectedRowStyle ForeColor="Black" Font-Bold="True" 
                        BackColor="#99ccff"></SelectedRowStyle>

                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnEditContact" runat="server" Text="Update Selected Contact" OnClick="btnEditContact_Click" />
                <asp:Button ID="btnAddContact" runat="server" Text="Add New Contact" OnClick="btnAddContact_Click" />
            </td>
        </tr>
    </table>


</asp:Content>
