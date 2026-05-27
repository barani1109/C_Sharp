<%@ Page Language="C#" AutoEventWireup="true"
CodeBehind="Login.aspx.cs"
Inherits="CodeChallenge1.Login" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Admin Login</title>

    <style>
        body {
            margin: 0;
            padding: 0;
            font-family: Arial;
            background: linear-gradient(135deg, #1e3c72, #2a5298);
            height: 100vh;
            display: flex;
            justify-content: center;
            align-items: center;
        }

        .login-card {
            width: 380px;
            background: white;
            padding: 30px;
            border-radius: 12px;
            box-shadow: 0 10px 30px rgba(0,0,0,0.3);
        }

        .title {
            text-align: center;
            margin-bottom: 20px;
            color: #2a5298;
            font-size: 24px;
            font-weight: bold;
        }

        .input-box {
            width: 100%;
            padding: 10px;
            margin-top: 5px;
            margin-bottom: 15px;
            border: 1px solid #ccc;
            border-radius: 6px;
            outline: none;
        }

        .input-box:focus {
            border-color: #2a5298;
        }

        .btn {
            width: 100%;
            padding: 10px;
            background: #2a5298;
            color: white;
            border: none;
            border-radius: 6px;
            cursor: pointer;
            font-size: 16px;
        }

        .btn:hover {
            background: #1e3c72;
        }

        .error {
            color: red;
            text-align: center;
            display: block;
            margin-top: 10px;
        }

        .footer-text {
            text-align: center;
            margin-top: 15px;
            font-size: 12px;
            color: gray;
        }
    </style>

</head>

<body>

<form runat="server">

    <div class="login-card">

        <div class="title">Admin Login</div>

        <label>Username</label>
        <asp:TextBox ID="txtUsername" runat="server" CssClass="input-box"></asp:TextBox>

        <label>Password</label>
        <asp:TextBox ID="txtPassword" runat="server"
            TextMode="Password"
            CssClass="input-box"></asp:TextBox>

        <asp:Button ID="btnLogin"
            runat="server"
            Text="Login"
            CssClass="btn"
            OnClick="btnLogin_Click" />

        <asp:Label ID="lblMessage"
            runat="server"
            CssClass="error"></asp:Label>

        <div class="footer-text">
            Food Order Management System
        </div>

    </div>

</form>

</body>
</html>