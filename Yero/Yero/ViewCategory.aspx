<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewCategory.aspx.cs" MasterPageFile="~/Site1.Master"   Inherits="Yero.ViewCategory" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
         <table id="tblCategorygrid">
             <tr>
                 <td>
                     <asp:TreeView ID="TVCategory" runat="server"></asp:TreeView>
                 </td>

             </tr>

        <tr>
            <td>

                <asp:GridView Visible="false" ID="grdCategory" runat="server" AutoGenerateColumns="false" AutoGenerateSelectButton="true" OnSelectedIndexChanged="grdCategory_SelectedIndexChanged">
                    <Columns >
                        <asp:BoundField DataField="CategoryID" HeaderText="ID" />
                        <asp:BoundField DataField="CategoryName" HeaderText="Name" />
                        <asp:BoundField DataField="Description" HeaderText="Description" />
                    </Columns>
                    <SelectedRowStyle ForeColor="Black" Font-Bold="True" 
                        BackColor="#99ccff"></SelectedRowStyle>

                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnEditCategory" runat="server" Text="Update Selected Category" OnClick="btnEditCategory_Click" />
                <asp:Button ID="btnAddCategory" runat="server" Text="Add New Category" OnClick="btnAddCategory_Click" />

            </td>
        </tr>
    </table>
</asp:Content>
