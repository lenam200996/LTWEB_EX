using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class Cau4_Tinh : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Calculator cal = new Calculator();

        switch (DropDownList1.SelectedValue)
        {
            case "+":
                Label1.Text = cal.tong(Double.Parse(TextBox1.Text), Double.Parse(TextBox2.Text)).ToString();
                break;
            case "-":
                Label1.Text = cal.tru(Double.Parse(TextBox1.Text), Double.Parse(TextBox2.Text)).ToString();
                break;
            case "*":
                Label1.Text = cal.nhan(Double.Parse(TextBox1.Text), Double.Parse(TextBox2.Text)).ToString();
                break;
            case "/":
                Label1.Text = cal.chiaNguyen(Double.Parse(TextBox1.Text), Double.Parse(TextBox2.Text)).ToString();
                break;
            case "%":
                Label1.Text = cal.chiaDu(Double.Parse(TextBox1.Text), Double.Parse(TextBox2.Text)).ToString();
                break;
            case "^":
                Label1.Text = cal.luyThua(Double.Parse(TextBox1.Text), Double.Parse(TextBox2.Text)).ToString();
                break;
        }
    }
}