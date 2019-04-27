using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cau7 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        txtthongbao.Text = "";
        if (!Regex.IsMatch(txtsdt.Text, "^\\+?\\d{1,3}?[- .]?\\(?(?:\\d{2,3})\\)?[- .]?\\d\\d\\d[- .]?\\d\\d\\d\\d$"))
        {
            txtthongbao.Text += "Sdt khong hop le<br>";
        }
        else
        {
            txtthongbao.Text += "So dien thoai dung <br>";
        }
        if (!Regex.IsMatch(txtemail.Text, "^[a-z][a-z0-9_\\.]{5,32}@[a-z0-9]{2,}(\\.[a-z0-9]{2,4}){1,2}$"))
        {
           txtthongbao.Text += "Email khong hop le <br>";
        }
        else
        {
           txtthongbao.Text += "Email dung <br>";

        }
        if (!Regex.IsMatch(ngaythang.Text, "^(?:(?:31(\\/|-|\\.)(?:0?[13578]|1[02]))\\1|(?:(?:29|30)(\\/|-|\\.)(?:0?[1,3-9]|1[0-2])\\2))(?:(?:1[6-9]|[2-9]\\d)?\\d{2})$|^(?:29(\\/|-|\\.)0?2\\3(?:(?:(?:1[6-9]|[2-9]\\d)?(?:0[48]|[2468][048]|[13579][26])|(?:(?:16|[2468][048]|[3579][26])00))))$|^(?:0?[1-9]|1\\d|2[0-8])(\\/|-|\\.)(?:(?:0?[1-9])|(?:1[0-2]))\\4(?:(?:1[6-9]|[2-9]\\d)?\\d{2})$"))
        {
            txtthongbao.Text += "Ngay thang khong hop le <br>";
        }
        else
        {
            txtthongbao.Text += "Ngay thang dung <br>";

        }
    }
    

}