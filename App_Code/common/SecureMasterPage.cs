using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

/// <summary>
/// Zusammenfassungsbeschreibung für SecureMasterPage
/// </summary>
public abstract class SecureMasterPage : MasterPage
{
    public SecureMasterPage()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    protected override bool isSecurePage()
    {
        return true;
    }

    protected String loadNewestGamesIntoContainer()
    {
        StringBuilder htmlBuilder = new StringBuilder();
        List<Game> games = DataProvider.getInstance().getAllGame();
        foreach(Game game in games)
        {
            htmlBuilder.Append(createElement(game, "Jetzt ausleihen"));
        }
        return htmlBuilder.ToString();
    }

    private String createElement(Game game, String buttonText)
    {
        return "<a href=\"Detail.aspx?id="+game.gameId+"\"><div class=\"flexItem\"><div class=\"mainItemImage\"> <img src=\""+game.imageLink+"\" /></div> <div class=\"mainItemTitle\"><h1>"+game.name+"</h1><p>"+game.description+"</p></div><button class=\"button\" style=\"vertical-align:middle\"><span>"+buttonText+"</span></button></div></a>";
    }
}