<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RegisterPage.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Registrieren</title>
</head>
<body>
	<p>Fülle folgende Felder aus</p>
    <form id="loginForm" runat="server">
		<table>
		<tr><td>
				<label for="EmailField">E-Mail:</label>
		    </td>
			<td>
				<asp:TextBox ID="EmailField" runat="server" />
				<asp:RequiredFieldValidator ID="requiredInputFieldValidator" ControlToValidate="EmailField" ErrorMessage="Bitte füllen Sie das Feld aus" runat="server" />
			</td>
		</tr>
           <tr><td>
				<label for="EmailRepeatField">E-Mail bestätigen:</label>
		    </td>
			<td>
				<asp:TextBox ID="EmailRepeatField" runat="server" />
				<asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="EmailRepeatField" ErrorMessage="Bitte füllen Sie das Feld aus" runat="server" />
                <asp:CompareValidator ID="CompareMailValidator" ControlToValidate="EmailRepeatField" ControlToCompare="EmailField" ErrorMessage="Bitte geben Sie die identische Mail" type="String" runat="server" />
			</td>
		</tr>
		<tr>
			<td>
				<label for="PasswordField" runat="server" />Password:</label>
			</td>
			<td>
				<asp:TextBox ID="PasswordField" TextMode="Password" runat="server" />
				<asp:RequiredFieldValidator ID="requiredInputPwFieldValidator" ControlToValidate="PasswordField" ErrorMessage="Bitte füllen Sie das Feld aus" runat="server" />
			</td>
		</tr>
		<tr>
			<td></td>
			<td>
				<input type="submit" value="Registrieren" id="registerButton" runat="server"/>
			</td>
		</tr>
		</table>
    </form>
</body>
</html>
