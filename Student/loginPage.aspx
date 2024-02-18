<%@ Page Language="C#" AutoEventWireup="true" CodeFile="loginPage.aspx.cs" Inherits="Default3" %>




<!DOCTYPE html>
<html>
<head>
	<title>Flex login</title>
	<link rel="stylesheet" type="text/css" href="style.css">
</head>
<body>
    <img src="flex-logo-blue.png" alt="Logo" class="logo"> 

    <div class="container">
		
        <form runat="server">
			<h2> Login</h2>
			<label for="Roll No">Roll No:</label>
			<asp:TextBox ID="RollNoTextBox" runat="server" placeholder="Enter your Roll No (21I-XXXX)"></asp:TextBox>

			<label for="Password">Password:</label>
			 <asp:TextBox ID="PasswordTextBox" runat="server" TextMode="Password" placeholder="Enter your Password"></asp:TextBox>

			<input type="submit" value="Login">
		</form>
	</div>
</body>
</html>