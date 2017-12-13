using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{
		if(IsPostBack)
		{
            handleRegister();

        }
		handleSession();
	}

	/**
	 * Redirect to User-Section if User already logged in 
	 **/
	private void handleSession()
	{
		String sessionKey = (String)Session["key"];
		if (sessionKey != null)
		{
			redirectToUserSection();
		}
	}

	/**
	 * Redirect User to MainPage if logged in
	 **/
	private void redirectToUserSection()
	{
		//Response.Redirect("MainMenu.aspx");
	}

    private void handleRegister()
    {
        String email = EmailField.Text;
        String password = PasswordField.Text;
        User newUser = new User(email, password);
        if(!DataProvider.getInstance().doesUserExist(newUser))
        {
            servererror.InnerHtml = "";
            DataHandler.getInstance().saveUserInformation(newUser);
        }
        else
        {
            servererror.InnerHtml = "Nutzer existiert bereits!";
        }
        
    }
}