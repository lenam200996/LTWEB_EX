using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UserControl_ucMenu : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session.Count != 0) { 
            if (Session["login"] != "Đăng nhập")
                txtlogin.Text = "Xin chao " + Session["login"] + " | " + "<a href='Login.aspx'>Đăng xuất</a>";
            else
                txtlogin.Text = "Đăng nhập";
        }
        else
        {
            txtlogin.Text = "Đăng nhập";
        }
    }
}