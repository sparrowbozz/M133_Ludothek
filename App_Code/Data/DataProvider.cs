using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

/// <summary>
/// Holt Daten von Files
/// </summary>
public class DataProvider
{

    private static DataProvider instance;

    private DataProvider()
    {

    }

    public static DataProvider getInstance()
    {
        if (instance == null)
        {
            instance = new DataProvider();
        }
        return instance;
    }

    public bool doesUserExist(User user)
    {
        DataHelper.createFileAndDirectory(AppConst.USER_FILE);
        String userJson = DataHelper.getContentOfFile(AppConst.USER_FILE);
        List<User> users = JsonConvert.DeserializeObject<List<User>>(userJson);
        foreach(User tmpUser in users)
        {
            if(tmpUser.email == user.email)
            {
                return true;
            }
        }
        return false;
    }

    public String getUserInformationen(User user)
    {
        return "";
    }

   

    






}