using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class kt_giaiptbac2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        double a = Convert.ToDouble(TextBox1.Text);
        double b = Convert.ToDouble(TextBox2.Text);
        double c = Convert.ToDouble(TextBox3.Text);


        if (a == 0)
        {
            if (b == 0)
            {
                if (c == 0)
                {
                    Response.Write("phương trình có vô số nghiệm");
                }
                else
                {
                    Response.Write("phương trình vô nghiệm");
                }
            }
            else
            {
                TextBox4.Text = (-c / b).ToString();
            }
        }
        else
        {
            double denta = b * b - 4 * a * c;
            if (denta < 0)
            {
                Response.Write("phương trình vô nghiệm");
            }
            else if (denta == 0)
            {
                TextBox4.Text =(-b/(2*a)).ToString();
            }
            else
            {
                TextBox4.Text = ((-b + Math.Sqrt(denta)) / (2 * a)).ToString();
                TextBox5.Text = ((-b - Math.Sqrt(denta)) / (2 * a)).ToString();
            }
        }
    }
}