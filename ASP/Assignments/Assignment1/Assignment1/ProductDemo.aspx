<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="ProductDemo.aspx.cs"
    Inherits="Assignment1.ProductDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title>Product Demo</title>

    <style>
        body {
            width: 450px;
            margin: 40px auto;
            padding: 20px;
            border: 1px solid #ddd;
            border-radius: 15px;
            font-family: Arial;
            text-align: center;
        }

        h2 {
            margin-bottom: 20px;
        }

        select, button {
            padding: 8px;
            margin: 10px;
            border-radius: 8px;
        }

        img {
            margin-top: 10px;
            border-radius: 10px;
        }
    </style>

</head>

<body>

<form id="form1" runat="server">

<div>

    <h2>Products</h2>

    <asp:DropDownList ID="ddlProducts"
        runat="server"
        AutoPostBack="true"
        OnSelectedIndexChanged="ddlProducts_SelectedIndexChanged">
    </asp:DropDownList>

    <br />

    <asp:Image ID="imgProduct"
        runat="server"
        Height="200px"
        Width="250px" />

    <br />

    <asp:Button ID="btnPrice"
        runat="server"
        Text="Get Price"
        OnClick="btnPrice_Click" />

    <br />

    <asp:Label ID="lblPrice"
        runat="server"
        Font-Bold="true"
        ForeColor="Blue">
    </asp:Label>

</div>

</form>

</body>

</html>