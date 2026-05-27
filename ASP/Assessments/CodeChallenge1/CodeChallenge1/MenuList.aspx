<%@ Page Title="" Language="C#"
MasterPageFile="~/Site.Master"
AutoEventWireup="true"
CodeBehind="MenuList.aspx.cs"
Inherits="CodeChallenge1.MenuList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<style>
    .page-container {
        padding: 20px;
        font-family: Arial;
    }

    .title {
        text-align: center;
        color: #2a5298;
        margin-bottom: 20px;
    }

    .grid-box {
        width: 90%;
        margin: auto;
        background: white;
        padding: 20px;
        border-radius: 10px;
        box-shadow: 0px 5px 15px rgba(0,0,0,0.2);
    }

    .grid {
        width: 100%;
        border-collapse: collapse;
    }

    .grid th {
        background: #2a5298;
        color: white;
        padding: 10px;
        text-align: center;
    }

    .grid td {
        padding: 10px;
        text-align: center;
        border-bottom: 1px solid #ddd;
    }

    .grid tr:hover {
        background: #f2f6ff;
    }

    .action-link {
        padding: 5px 10px;
        border-radius: 5px;
        text-decoration: none;
        color: white;
        font-size: 13px;
    }

    .view {
        background: #17a2b8;
    }

    .edit {
        background: #28a745;
    }

    .delete {
        background: #dc3545;
        border: none;
        padding: 6px 10px;
        border-radius: 5px;
        color: white;
        cursor: pointer;
    }

    .add-btn {
        display: inline-block;
        margin-bottom: 15px;
        padding: 10px 15px;
        background: #2a5298;
        color: white;
        text-decoration: none;
        border-radius: 5px;
    }

    .add-btn:hover {
        background: #1e3c72;
    }
</style>

<div class="page-container">

    <h2 class="title"> Menu Management Dashboard</h2>

    <div style="text-align:center;">
        <a class="add-btn" href="AddEditMenu.aspx">+ Add New Item</a>
    </div>

    <div class="grid-box">

        <asp:GridView ID="gvMenu"
            runat="server"
            AutoGenerateColumns="False"
            DataKeyNames="MenuId"
            CssClass="grid"
            OnRowDeleting="gvMenu_RowDeleting">

            <Columns>

                <asp:BoundField DataField="MenuId" HeaderText="ID" />

                <asp:BoundField DataField="ItemName" HeaderText="Item Name" />

                <asp:BoundField DataField="Category" HeaderText="Category" />

                <asp:BoundField DataField="Price" HeaderText="Price" />

                <asp:HyperLinkField HeaderText="View"
                    DataNavigateUrlFields="MenuId"
                    DataNavigateUrlFormatString="MenuDetails.aspx?MenuId={0}"
                    Text="View" />

                <asp:HyperLinkField HeaderText="Edit"
                    DataNavigateUrlFields="MenuId"
                    DataNavigateUrlFormatString="AddEditMenu.aspx?MenuId={0}"
                    Text="Edit" />

                <asp:CommandField ShowDeleteButton="True" />

            </Columns>

        </asp:GridView>

    </div>

</div>

</asp:Content>