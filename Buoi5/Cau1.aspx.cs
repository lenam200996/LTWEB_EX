using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cau1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            double a = TextBox1.Text.Trim() == null ? 0 : Convert.ToDouble(TextBox1.Text);
            double b = TextBox2.Text.Trim() == null ? 0 : Convert.ToDouble(TextBox2.Text);

            TextBox3.Text = (a + b).ToString();
        }
        catch (Exception ex)
        {
            TextBox3.Text = "du lieu loi";
        }
       
    }
}