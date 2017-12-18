using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MainMenu : SecureMasterPage
{

    protected override void setupPageWithSession(Session session)
    {
        UserDetail detail = DataProvider.getInstance().getUserDetail(session.userId);
        username.InnerHtml = detail.anrede + " " + detail.vorname + " " + detail.nachname;
        String gameHtml = loadNewestGamesIntoContainer();
        flexContainer.InnerHtml = gameHtml;
    }

    protected override void handlePostback()
    {
        Console.Write("Es ist postback!");
    }

}