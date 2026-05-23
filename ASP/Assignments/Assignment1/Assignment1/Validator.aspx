﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Validator.aspx.cs" Inherits="Assignment1.Validator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
       body {
    width: 500px;
    margin: 40px auto;
    padding: 20px;
    border: 1px solid #ddd;
    border-radius: 15px;
    font-family: Arial;
}

button {
    padding: 8px 16px;
    margin-bottom: 10px;
    margin-right: 8px;
    border-radius: 20px;
    border: none;
    cursor: pointer;
}       
    </style>
</head>
<body>
    <form id="form1" runat="server">
         <div>
            Name:
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvName" runat="server" 
                ControlToValidate="txtName" ErrorMessage="Name required" ForeColor="Red" />
            <br /><br />

            Family Name:
            <asp:TextBox ID="txtFamilyName" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvFamily" runat="server" 
                ControlToValidate="txtFamilyName" ErrorMessage="Family Name required" ForeColor="Red" />
            <asp:CompareValidator ID="cvNameFamily" runat="server"
                ControlToValidate="txtName" ControlToCompare="txtFamilyName"
                Operator="NotEqual" ErrorMessage="Name must differ from Family Name" ForeColor="Red" />
            <br />

            Address:
            <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvAddress" runat="server" 
                ControlToValidate="txtAddress" ErrorMessage="Address required" ForeColor="Red" />
            <asp:RegularExpressionValidator ID="revAddress" runat="server"
                ControlToValidate="txtAddress" ValidationExpression=".{2,}"
                ErrorMessage="Address must be at least 2 characters" ForeColor="Red" />
            <br />

            City:
            <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvCity" runat="server" 
                ControlToValidate="txtCity" ErrorMessage="City required" ForeColor="Red" />
            <asp:RegularExpressionValidator ID="revCity" runat="server"
                ControlToValidate="txtCity" ValidationExpression=".{2,}"
                ErrorMessage="City must be at least 2 characters" ForeColor="Red" />
            <br />

            Zip Code:
            <asp:TextBox ID="txtZip" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvZip" runat="server" 
                ControlToValidate="txtZip" ErrorMessage="Zip required" ForeColor="Red" />
            <asp:RegularExpressionValidator ID="revZip" runat="server"
                ControlToValidate="txtZip" ValidationExpression="^\d{5}$"
                ErrorMessage="Zip must be 5 digits" ForeColor="Red" />
            <br /><br />

            Phone:
            <asp:TextBox ID="txtPhone" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvPhone" runat="server" 
                ControlToValidate="txtPhone" ErrorMessage="Phone required" ForeColor="Red" />
            <asp:RegularExpressionValidator ID="revPhone" runat="server"
                ControlToValidate="txtPhone" ValidationExpression="^\d{2,3}-\d{7}$"
                ErrorMessage="Phone format XX-XXXXXXX or XXX-XXXXXXX" ForeColor="Red" />
            <br />

            Email:
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvEmail" runat="server" 
                ControlToValidate="txtEmail" ErrorMessage="Email required" ForeColor="Red" />
            <asp:RegularExpressionValidator ID="revEmail" runat="server"
                ControlToValidate="txtEmail" ValidationExpression="^[^@\s]+@[^@\s]+\.[^@\s]+$"
                ErrorMessage="Invalid email format" ForeColor="Red" />
            <br /><br />

            <asp:Button ID="btnCheck" runat="server" Text="Check" OnClick="btnCheck_Click" />
            <br /><br />

            <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
                HeaderText="ValidationSum" ShowMessageBox="true" ShowSummary="true" ForeColor="Red" />
        </div>
    </form>
</body>
</html>