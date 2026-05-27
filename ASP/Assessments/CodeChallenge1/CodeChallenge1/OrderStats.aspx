<%@ Page Language="C#" AutoEventWireup="true"
CodeBehind="OrderStats.aspx.cs"
Inherits="CodeChallenge1.OrderStats" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Order Statistics Dashboard</title>

    <style>
        body {
            margin: 0;
            font-family: Arial;
            background: #f4f6f9;
        }

        .header {
            background: #2a5298;
            color: white;
            padding: 15px;
            text-align: center;
        }

        .container {
            width: 90%;
            margin: auto;
            margin-top: 20px;
        }

        .cards {
            display: flex;
            gap: 20px;
            justify-content: center;
            margin-bottom: 20px;
        }

        .card {
            flex: 1;
            background: white;
            padding: 20px;
            border-radius: 10px;
            box-shadow: 0px 5px 15px rgba(0,0,0,0.2);
            text-align: center;
        }

        .card h3 {
            margin: 0;
            color: #2a5298;
        }

        .btn {
            background: #2a5298;
            color: white;
            padding: 10px 15px;
            border: none;
            border-radius: 5px;
            cursor: pointer;
            margin: 10px 0;
        }

        .btn:hover {
            background: #1e3c72;
        }

        .message {
            text-align: center;
            font-weight: bold;
            margin: 10px 0;
        }

        .grid-box {
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
        }

        .grid td {
            padding: 10px;
            text-align: center;
            border-bottom: 1px solid #ddd;
        }
    </style>

</head>

<body>

<form id="form1" runat="server">

<div class="header">
    <h2> Order Statistics Dashboard</h2>
</div>

<div class="container">

    <div class="cards">

        <div class="card">
            <h3>Total Visitors</h3>
            <asp:Label ID="lblVisitors" runat="server" Font-Size="20px" Font-Bold="true"></asp:Label>
        </div>

        <div class="card">
            <h3>Active Users</h3>
            <asp:Label ID="lblUsers" runat="server" Font-Size="20px" Font-Bold="true"></asp:Label>
        </div>

    </div>

    <!-- BUTTON -->
    <div style="text-align:center;">
        <asp:Button ID="btnLoad" runat="server"
            Text="Load Category Statistics"
            CssClass="btn"
            OnClick="btnLoad_Click" />
    </div>

    <!-- MESSAGE -->
    <div class="message">
        <asp:Label ID="lblCacheMessage" runat="server"></asp:Label>
    </div>

    <!-- GRID -->
    <div class="grid-box">
        <asp:GridView ID="gvCategory" runat="server" CssClass="grid"></asp:GridView>
    </div>

</div>

</form>

</body>
</html>