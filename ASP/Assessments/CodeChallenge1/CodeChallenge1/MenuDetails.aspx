<%@ Page Language="C#" AutoEventWireup="true"
CodeBehind="MenuDetails.aspx.cs"
Inherits="CodeChallenge1.MenuDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Menu Details</title>

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
            font-size: 22px;
            font-weight: bold;
        }

        .container {
            width: 50%;
            margin: 40px auto;
        }

        .card {
            background: white;
            padding: 25px;
            border-radius: 12px;
            box-shadow: 0px 5px 20px rgba(0,0,0,0.2);
            text-align: center;
        }

        .title {
            font-size: 26px;
            color: #2a5298;
            margin-bottom: 15px;
        }

        .label {
            font-size: 18px;
            margin: 10px 0;
            display: block;
        }

        .price {
            font-size: 22px;
            color: green;
            font-weight: bold;
        }

        .badge {
            display: inline-block;
            padding: 5px 10px;
            border-radius: 5px;
            background: #1e3c72;
            color: white;
            margin-top: 10px;
        }

        .back-btn {
            margin-top: 20px;
            display: inline-block;
            padding: 10px 15px;
            background: #2a5298;
            color: white;
            text-decoration: none;
            border-radius: 5px;
        }

        .back-btn:hover {
            background: #1e3c72;
        }
    </style>

</head>

<body>

<form id="form1" runat="server">

    <div class="header">
         Menu Details
    </div>

    <div class="container">

        <div class="card">

            <div class="title">
                <asp:Label ID="lblItemName" runat="server"></asp:Label>
            </div>

            <span class="label">
                
                <asp:Label ID="lblCategory" runat="server"></asp:Label>
            </span>

            <span class="label price">
              
                ₹<asp:Label ID="lblPrice" runat="server"></asp:Label>
            </span>

            <br />

            <a class="back-btn" href="MenuList.aspx">⬅ Back to Menu</a>

        </div>

    </div>

</form>

</body>
</html>