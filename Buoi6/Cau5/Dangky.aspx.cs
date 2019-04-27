using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cau5_Dangky : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Session["us"] = TextBox1.Text;
        Session["pw"] = TextBox2.Text;
        Session["email"] = TextBox4.Text;
        Session["gioitinh"] = RadioButton1.Checked ? RadioButton1.Text : RadioButton2.Text;
        Session["ngaysinh"] = TextBox5.Text;

        string sothich = "";
        if (CheckBox1.Checked) sothich += CheckBox1.Text+ " ";
        if (CheckBox2.Checked) sothich += CheckBox2.Text + " ";
        if (CheckBox3.Checked) sothich += CheckBox3.Text + " ";
        Session["sothich"] = sothich;

        Response.Redirect("Thongtin.aspx");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";
        TextBox5.Text = "";

    }
}