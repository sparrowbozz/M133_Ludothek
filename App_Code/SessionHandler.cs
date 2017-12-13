using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Zusammenfassungsbeschreibung für SessionHandler
/// </summary>
public class SessionHandler
{

	private static SessionHandler instance;

	public static SessionHandler getInstance()
	{
		if (instance == null)
		{
			instance = new SessionHandler();
		}
		return instance;
	}

	private String userToken;

	private SessionHandler()
	{
		
	}

	public bool loginUser(String username, String password)
	{
		if (checkUserLogin(username, password)) {
			userToken = generateUserToken();
		}
		return true;
	}

	public bool isUserLoggedIn()
	{
		return userToken != null;
	}

	public void logoutUser()
	{
		userToken = null;
	}

	private String generateUserToken()
	{
		return "userLoggedIn";
	}

	public String getUserToken()
	{
		return userToken;
	}

	private bool checkUserLogin(String email, String password)
	{
        User newUser = new User(email, password);
        if (DataProvider.getInstance().doesUserExist(newUser))
        {
            return true;
        }
        return false;
	}

}