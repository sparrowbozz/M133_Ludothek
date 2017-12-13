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
			handleLogin();
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
		Response.Redirect("MainMenu.aspx");
	}

    private void handleRegister()
    {
        //String email
    }

	private void handleLogin()
	{
		String username = EmailField.Text;
		String password = PasswordField.Text;
		if (SessionHandler.getInstance().loginUser(username, password))
		{
			Session["key"] = SessionHandler.getInstance().getUserToken();
		}

	}
}