using System;
using System.Collections.Generic;
using System.Linq;
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
        DateTime date = DateTime.Now;
        if (TextBox3.Text.Trim() != "")
        {
            if (Convert.ToInt32(TextBox3.Text.Trim()) > date.Year)
            {
                Response.Write("Nam ban nhap khong duoc lon hon nam hien tai");
            }
            else
            {
                Response.Write("<b><u>" + (date.Year - Convert.ToInt32(TextBox3.Text.Trim())) + "</u></b>");
            }
        }
        else
        {
            Response.Write("Vui long nhap noi dung!");
        }
    }
}