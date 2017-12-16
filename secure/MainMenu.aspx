<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MainMenu.aspx.cs" Inherits="MainMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>

    <link rel="stylesheet" href="design/design.css" />


</head>
<body>
    <header class="clearfix">
        <div id="mainContainerHeader">
            <nav>
                
                <div class="navigationElement" id="user">
                    
                        Willkommen XXXXX, <a href="userInformation.aspx" />PROFIL BEARBEITEN</a>
                    

                    
                </div>
                <div class="navigationElement">
                    <a>Spiele</a>
                </div>
                <div class="navigationElement">
                    <a>Kontakt</a>
                </div>
                
            </nav>
        </div>
    </header>
    
    <div id="wrapper">
        <aside>
            <div id="containterSideBar">
                <div class="sideElement">
                    <a>Neuste Spiele</a>
                </div>
                <div class="sideElement">
                    <a>Bereits ausgeliehen</a>
                </div>
                <div class="sideElement">
                    <a>Aktuell ausgeliehen</a>
                </div>
            </div>

        </aside>
        <main>
            <div id="containerMain">
                
                <div id="flexContainer">

                    <!--Items-->
                    <div class="flexItem">
                        <div class="mainItemImage">
                            <img src="http://1images.cgames.de/images/gamestar/207/call-of-duty-4-modern-warfare_1821710.jpg" />
                        </div>
                        <div class="mainItemTitle">
                            <h1>Call of Duty</h1>
                            <p>Call of Duty ist eine Computerspielreihe des amerikanischen Publishers Activision aus dem Genre der Ego-Shooter. Der Spieler übernimmt darin üblicherweise die Rolle eines Soldaten in einem Kriegsszenario.</p>
                        </div>
                        <button class="button" style="vertical-align:middle"><span>Jetzt auslehnen </span></button>
                    </div>
                    <div class="flexItem">
                        <div class="mainItemImage">
                            <img src="http://1images.cgames.de/images/gamestar/207/call-of-duty-4-modern-warfare_1821710.jpg" />
                        </div>
                        <div class="mainItemTitle">
                            <h1>Call of Duty</h1>
                            <p>Call of Duty ist eine Computerspielreihe des amerikanischen Publishers Activision aus dem Genre der Ego-Shooter. Der Spieler übernimmt darin üblicherweise die Rolle eines Soldaten in einem Kriegsszenario.</p>
                        </div>
                        <button class="button" style="vertical-align:middle"><span>Ausleihe verlängern</span></button>
                    </div>
                    

		            <a href="#!" onClick="handleLogoutClick()" runat="server"></a>

                </div>  
            </div>
        </main>
    </div>
    <footer>

    </footer>










    
</body>
</html>
