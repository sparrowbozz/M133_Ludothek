<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MainMenu.aspx.cs" Inherits="MainMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>

    <link rel="stylesheet" href="design/design.css" />


</head>
<body>
    <form id="form1" runat="server">
    
    <div id="mainContainer">

        <div class="items"></div>
        <div class="items"></div>
        <div class="items"></div>
        <div class="items"></div>

		<a href="#!" onClick="handleLogoutClick()" runat="server"></a>

    </div>


    </form>
</body>
</html>
