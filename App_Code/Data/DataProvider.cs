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
        if (instance == null)
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
        if (!File.Exists(AppConst.USER_FILE))
        {
            Directory.CreateDirectory(Path.GetDirectoryName(AppConst.USER_FILE));
            File.Create(AppConst.USER_FILE);
        }

        StreamReader reader = new StreamReader(AppConst.USER_FILE);
        String contentOfFile = reader.ReadToEnd();
        reader.Close();
        List<User> users = JsonConvert.DeserializeObject<List<User>>(contentOfFile);
        if(users == null)
        {
            users = new List<User>();
        }
        users.Add(newUser);

        String newJson = JsonConvert.SerializeObject(users);
        File.WriteAllText(AppConst.USER_FILE, newJson);
    }






}