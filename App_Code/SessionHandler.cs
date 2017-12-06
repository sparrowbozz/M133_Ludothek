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

	private String generateUserToken()
	{
		return "userLoggedIn";
	}

	public String getUserToken()
	{
		return userToken;
	}

	private bool checkUserLogin(String username, String password)
	{
		return (username == "admin" && password == "eli");
	}

}