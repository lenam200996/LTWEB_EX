using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cau5_Thongtin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        Label1.Text = "ten dang nhap: " + Session["us"] + "<br>"+"mat khau: " + Session["pw"] + "<br>" + "gioi tinh: " + Session["gioitinh"] + "<br>" + "ngay sinh: " + Session["ngaysinh"] + "<br>" + "so thich: " + Session["sothich"];
    }
}