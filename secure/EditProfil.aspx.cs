﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : SecureMasterPage
{
    protected override void setupPage(Session session)
    {
        if (session != null)
        {
            if(!IsPostBack)
            {
                UserDetail detail = DataProvider.getInstance().getUserDetail(session.userId);
                if(detail != null)
                {
                    AnredeField.Value = AnredeField.Items.FindByText(detail.anrede).Value;
                    VornameField.Text = detail.vorname;
                    NachnameField.Text = detail.nachname;
                    GeburtsdatumField.Text = detail.geburtsdatum;
                    TelefonField.Text = detail.telefon;
                    StrasseField.Text = detail.strasse;
                    PLZField.Text = detail.postleitzahl;
                    OrtField.Text = detail.ort;
                    LandField.Text = detail.land;

                    EmailField.Visible = true;
                    PasswortField.Visible = true;
                } else
                {
                    EmailField.Visible = false;
                    PasswortField.Visible = false;
                }
                User user = DataProvider.getInstance().getUserFromId(session.userId);
                EmailField.Text = user.email;
            }
        } else {
            Response.Redirect("../public/LoginPage.aspx");
        }
    }

    protected override void handlePostback()
    {
        handleSave();
    }

    private void handleSave()
    {
        bool hasError = false;
        User user = DataProvider.getInstance().getUserFromToken(getSessionKey());

        String anrede = Request.Form["AnredeField"];
        String vorname = VornameField.Text;
        String nachname = NachnameField.Text;
        String geburtsdatum = GeburtsdatumField.Text;
        String telefon = TelefonField.Text;
        String strasse = StrasseField.Text;
        String plz = PLZField.Text;
        String ort = OrtField.Text;
        String land = LandField.Text;
        UserDetail detail = new UserDetail(user.userId, anrede, vorname, nachname, geburtsdatum, telefon, strasse, plz, ort, land);


        if (PasswortField.Visible && EmailField.Visible)
        {

            String originalEmail = user.email;
            String inputMail = EmailField.Text;

            bool userHasChanges = false;
            if (!originalEmail.Equals(inputMail))
            {
                User searchedUser = DataHandler.getInstance().doesUserExist(new User(-1, inputMail, ""));
                if (searchedUser == null)
                {
                    user.email = inputMail;
                    userHasChanges = true;
                }
                else
                {
                    servererror.InnerText = "Nutzer mit Mail besteht bereits!";
                    hasError = true;
                }
            }

            if (PasswortField.Text != "")
            {
                user.password = PasswortField.Text;
                userHasChanges = true;
            }

            if (userHasChanges)
            {
                if (!hasError)
                {
                    DataHandler.getInstance().updateUser(user);
                }
            }
        }

        if (!hasError)
        {
            DataHandler.getInstance().saveDetailOfUser(detail);
            Response.Redirect("../secure/MainMenu.aspx");
        }
    }

    protected override string getPageName()
    {
        return AppConst.DETAIL_FORM_PAGE_NAME;
    }

}