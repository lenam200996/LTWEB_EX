using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cau1_LINQ_DangNhap : System.Web.UI.Page
{
    UsersDBDataContext myDBContext;
    protected void Page_Load(object sender, EventArgs e)
    {
        myDBContext = new UsersDBDataContext();
    }


    protected void btnDangNhap_Click(object sender, EventArgs e)
    {
        var sv = from item in myDBContext.Users
                 where item.UserName == txtUs.Text && item.PassWord == txtPw.Text
                 select item;

        if (sv.Count() > 0)
        {
            Session["userlinq"] = txtUs.Text;
            Response.Redirect("Main.aspx");
        }
        else
        {
            Response.Write("<script>alert('Sai username hoac password!');</script>");
        }
    }
}