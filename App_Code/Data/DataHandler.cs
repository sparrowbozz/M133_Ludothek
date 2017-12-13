using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

/// <summary>
/// Speichert Daten in Files ab
/// </summary>
public class DataHandler
{

    private static DataHandler instance;

    public static DataHandler getInstance()
    {
        if(instance==null)
        {
            instance = new DataHandler();
        }
        return instance;
    }
    
    private DataHandler()
    {
    }

    public void saveUserInformation(User newUser)
    {

        DataHelper.createFileAndDirectory(AppConst.USER_FILE);
        String contentOfFile = DataHelper.getContentOfFile(AppConst.USER_FILE);
        List<User> users = JsonConvert.DeserializeObject<List<User>>(contentOfFile);
        if (users == null)
        {
            users = new List<User>();
        }
        users.Add(newUser);

        String newJson = DataHelper.createJsonFromObject(users);
        DataHelper.saveDataToFile(AppConst.USER_FILE, newJson, true);
    }


}