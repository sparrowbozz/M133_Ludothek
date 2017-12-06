<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LoginPage.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="loginForm" runat="server">
		<table>
		<tr><td>
				<label for="UsernameField">Username:</label>
		    </td>
			<td>
				<asp:TextBox ID="UsernameField" runat="server" />
				<asp:RequiredFieldValidator ID="requiredInputFieldValidator" ControlToValidate="UsernameField" ErrorMessage="Please fill in the field" runat="server" />
			</td>
		</tr>
		<tr>
			<td>
				<label for="PasswordField" runat="server" />Password:</label>
			</td>
			<td>
				<asp:TextBox ID="PasswordField" runat="server" />
				<asp:RequiredFieldValidator ID="requiredInputPwFieldValidator" ControlToValidate="PasswordField" ErrorMessage="Please fill in your password" runat="server" />
			</td>
		</tr>
		<tr>
			<td></td>
			<td>
				<input type="submit" value="Login" id="loginButton" runat="server"/>
			</td>
		</tr>
		</table>
    </form>
</body>
</html>
