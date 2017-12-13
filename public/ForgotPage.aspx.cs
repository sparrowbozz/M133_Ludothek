using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class public_ForgotPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(IsPostBack)
        {
            handleForgotPassword();
        }
    }

    private void handleForgotPassword()
    {
        String forgotEmail = EmailField.Text;

    }
}