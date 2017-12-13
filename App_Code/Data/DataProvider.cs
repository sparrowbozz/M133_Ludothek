using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

/// <summary>
/// Zusammenfassungsbeschreibung für DataProvider
/// </summary>
public class DataProvider
{

    private static DataProvider instance;

    private DataProvider()
    {
        
    }

    public static DataProvider getInstance()
    {
        if(instance==null)
        {
            instance = new DataProvider();
        }
        return instance;
    }

    public String getUserInformationen(String username)
    {
        return "";
    }

    public void saveUserInformation(User newUser)
    {
        String json = JsonConvert.SerializeObject(newUser);
        Console.Write(json);
        if(File.Exists(AppConst.USER_FILE))
        {
            File.AppendText(json);
        }
    }




}