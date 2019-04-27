using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Session["login"] = "Đăng nhập";
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (txtTaiKhoan.Text == "" || txtMatKhau.Text == "")
        {
            Response.Write("<script>alert('tai khoan hoac mat khau khong duoc bo trong');</script>");
            return;
        }
        else
        {
            if (txtTaiKhoan.Text == "admin" && txtMatKhau.Text == "admin")
            {
                Session["login"] = "admin";
                Response.Redirect("home.aspx");
            }
            else if (txtTaiKhoan.Text == "user" && txtMatKhau.Text == "user")
                 {
                    Session["login"] = "user";
                        Response.Redirect("home.aspx");
                       
                    }
                    else
                    {
                        Response.Write("<script>alert('Sai tai khoan hoac mat khau!');</script>");
                    }
          
        }
    }
}