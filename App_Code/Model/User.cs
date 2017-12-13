using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Zusammenfassungsbeschreibung für User
/// </summary>
public class User
{

    public String email;
    public String password;

    public User(String email, String password)
    {
        this.email = email;
        this.password = password;
    }
}