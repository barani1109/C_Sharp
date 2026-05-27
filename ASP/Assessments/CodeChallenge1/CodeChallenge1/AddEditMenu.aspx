<%@ Page Title="" Language="C#"
MasterPageFile="~/Site.Master"
AutoEventWireup="true"
CodeBehind="AddEditMenu.aspx.cs"
Inherits="CodeChallenge1.AddEditMenu" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<style>
    .form-box {
        width: 450px;
        margin: 20px auto;
        padding: 20px;
        border: 1px solid #ccc;
        border-radius: 10px;
        background: #f9f9f9;
        font-family: Arial;
    }

    table {
        width: 100%;
    }

    td {
        padding: 8px;
    }

    .btn {
        background: green;
        color: white;
        padding: 8px 15px;
        border: none;
        border-radius: 5px;
        cursor: pointer;
    }

    .title {
        text-align: center;
        color: darkblue;
    }
</style>

<div class="form-box">

    <h2 class="title">
        <asp:Label ID="lblTitle" runat="server" Text="Add Menu Item"></asp:Label>
    </h2>

    <table>

        <tr>
            <td>Item Name</td>
            <td>
                <asp:TextBox ID="txtItemName" runat="server" />
                <asp:RequiredFieldValidator runat="server"
                    ControlToValidate="txtItemName"
                    ErrorMessage="Required"
                    ForeColor="Red" />
            </td>
        </tr>

        <tr>
            <td>Price</td>
            <td>
                <asp:TextBox ID="txtPrice" runat="server" />

                <asp:RangeValidator runat="server"
                    ControlToValidate="txtPrice"
                    MinimumValue="1"
                    MaximumValue="1000"
                    Type="Double"
                    ErrorMessage="1 to 1000"
                    ForeColor="Red" />
            </td>
        </tr>

        <tr>
            <td>Category</td>
            <td>
                <asp:TextBox ID="txtCategory" runat="server" />
            </td>
        </tr>

        <tr>
            <td>Food Type</td>
            <td>
                <asp:RadioButtonList ID="rblFoodType" runat="server">
                    <asp:ListItem>Veg</asp:ListItem>
                    <asp:ListItem>NonVeg</asp:ListItem>
                </asp:RadioButtonList>
            </td>
        </tr>

        <tr>
            <td>Quantity</td>
            <td>
                <asp:TextBox ID="txtQty" runat="server" />
            </td>
        </tr>

        <tr>
            <td>Available</td>
            <td>
                <asp:CheckBox ID="chkAvailable" runat="server" />
            </td>
        </tr>

        <tr>
            <td colspan="2" style="text-align:center;">
                <asp:Button ID="btnSave"
                    runat="server"
                    Text="Save"
                    CssClass="btn"
                    OnClick="btnSave_Click" />
            </td>
        </tr>

    </table>

    <asp:ValidationSummary runat="server" ForeColor="Red" />

</div>

</asp:Content>