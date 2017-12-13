using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Zusammenfassungsbeschreibung für AppConst
/// </summary>
public class AppConst
{
    public AppConst()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public static String USER_FILE = "C:\\Users\\"+ getUsername() + "\\Documents\\Visual Studio 2015\\Ludothek\\users.txt";

    private static String getUsername()
    {
        return Environment.UserName;
    }
}