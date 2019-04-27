using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cau1_ADO_DangNhap : System.Web.UI.Page
{

    SqlConnection con;
    SqlCommand myCom;
    protected void Page_Load(object sender, EventArgs e)
    {
        String strCon = "Data Source=DESKTOP-U5V2563;Initial Catalog=LTW_USER;User ID=sa;Password=123456";
        con = new SqlConnection(strCon);
        con.Open();
    }


    protected void btnDangNhap_Click(object sender, EventArgs e)
    {
        String sql = "select * from Users where UserName = '"+txtUs.Text+"' and PassWord = '"+txtPw.Text+"'";
        myCom = new SqlCommand(sql, con);
        SqlDataReader rd = myCom.ExecuteReader();
        if (rd.HasRows)
        {
            Session["user"] = txtUs.Text;
            Response.Redirect("Main.aspx");
        }
        else
        {
            Response.Write("<script>alert('Sai tài khoản hoặc mật khẩu!')</script>");
        }
    }
}