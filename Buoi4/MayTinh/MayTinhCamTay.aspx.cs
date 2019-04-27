using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MayTinhCamTay : System.Web.UI.Page
{
    private static double number1 = 0;
    private double number2 = 0;
    private static string prevOp = "";
    private static double kq = 0;
    private static bool op = false;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnClear_Click(object sender, EventArgs e)
    {
        txtNhapPhepTinh.Text = null;
        number1 = 0;
        kq = 0;
        op = false;
        txtOp.Text = "";
    }
   
    protected void txtNhapPhepTinh_TextChanged(object sender, EventArgs e)
    {

    }
    protected void btnNum1_Click(object sender, EventArgs e)
    {
        if (op)
        {
            txtNhapPhepTinh.Text = "1";
            op = false;
        }
        else
        {
            txtNhapPhepTinh.Text += "1";
        }
        
    }
    protected void btnNum2_Click(object sender, EventArgs e)
    {
        if (op)
        {
            txtNhapPhepTinh.Text = "2";
            op = false;
        }
        else
        {
            txtNhapPhepTinh.Text += "2";
        } 
    }
    protected void btnNum3_Click(object sender, EventArgs e)
    {
        if (op)
        {
            txtNhapPhepTinh.Text = "3";
            op = false;
        }
        else
        {
            txtNhapPhepTinh.Text += "3";
        }
    }
    protected void btnNum4_Click(object sender, EventArgs e)
    {
        if (op)
        {
            txtNhapPhepTinh.Text = "4";
            op = false;
        }
        else
        {
            txtNhapPhepTinh.Text += "4";
        } 
    }
    protected void btnNum5_Click(object sender, EventArgs e)
    {
        if (op)
        {
            txtNhapPhepTinh.Text = "5";
            op = false;
        }
        else
        {
            txtNhapPhepTinh.Text += "5";
        } 
    }
    protected void btnNum6_Click(object sender, EventArgs e)
    {
        if (op)
        {
            txtNhapPhepTinh.Text = "6";
            op = false;
        }
        else
        {
            txtNhapPhepTinh.Text += "6";
        }
    }
    protected void btnNum7_Click(object sender, EventArgs e)
    {
        if (op)
        {
            txtNhapPhepTinh.Text = "7";
            op = false;
        }
        else
        {
            txtNhapPhepTinh.Text += "7";
        }
    }
    protected void btnNum8_Click(object sender, EventArgs e)
    {
        if (op)
        {
            txtNhapPhepTinh.Text = "8";
            op = false;
        }
        else
        {
            txtNhapPhepTinh.Text += "8";
        } 
    }
    protected void btnNum9_Click(object sender, EventArgs e)
    {
        if (op)
        {
            txtNhapPhepTinh.Text = "9";
            op = false;
        }
        else
        {
            txtNhapPhepTinh.Text += "9";
        } 
    }

    protected void btnNum0_Click(object sender, EventArgs e)
    {
        if (op)
        {
            txtNhapPhepTinh.Text = "0";
            op = false;
        }
        else
        {
            txtNhapPhepTinh.Text += "0";
        } 
    }
    protected void btnCham_Click(object sender, EventArgs e)
    {
        if (!op)
        {
            if (!txtNhapPhepTinh.Text.Contains("."))
                txtNhapPhepTinh.Text += ".";
        }
    }

    protected void btncong_Click(object sender, EventArgs e)
    {
        if (prevOp != "")
        {
            switch (prevOp)
            {
                case "+":
                    kq = number1 + Convert.ToDouble(txtNhapPhepTinh.Text);
                    break;
                case "-":
                    kq = number1 - Convert.ToDouble(txtNhapPhepTinh.Text);
                    break;
                case "*":
                    kq = number1 * Convert.ToDouble(txtNhapPhepTinh.Text);
                    break;
                case "/":
                    kq = number1 / Convert.ToDouble(txtNhapPhepTinh.Text);
                    break;
            }
            number1 = kq;
            prevOp = "+";
            txtOp.Text = prevOp;
            txtkq.Text = kq.ToString();
            op = true; 
        }
        else
        {
            number1 = Convert.ToDouble(txtNhapPhepTinh.Text);
            kq = number1;
            prevOp = "+"; txtOp.Text = prevOp;
            txtkq.Text = kq.ToString();
            op = true; 
        }
       

    }
    protected void btnTru_Click(object sender, EventArgs e)
    {
        if (prevOp != "")
        {
            switch (prevOp)
            {
                case "+":
                    kq = number1 + Convert.ToDouble(txtNhapPhepTinh.Text);
                    break;
                case "-":
                    kq = number1 - Convert.ToDouble(txtNhapPhepTinh.Text);
                    break;
                case "*":
                    kq = number1 * Convert.ToDouble(txtNhapPhepTinh.Text);
                    break;
                case "/":
                    kq = number1 / Convert.ToDouble(txtNhapPhepTinh.Text);
                    break;
            }
            number1 = kq;
            prevOp = "-"; txtOp.Text = prevOp;
            txtkq.Text = kq.ToString();
            op = true;
        }
        else
        {
            number1 = Convert.ToDouble(txtNhapPhepTinh.Text); kq = number1;
            prevOp = "-"; txtOp.Text = prevOp;
            txtkq.Text = kq.ToString();
            op = true;
        }
    }

    protected void btnnhan_Click(object sender, EventArgs e)
    {
        if (prevOp != "")
        {
            switch (prevOp)
            {
                case "+":
                    kq = number1 + Convert.ToDouble(txtNhapPhepTinh.Text);
                    break;
                case "-":
                    kq = number1 - Convert.ToDouble(txtNhapPhepTinh.Text);
                    break;
                case "*":
                    kq = number1 * Convert.ToDouble(txtNhapPhepTinh.Text);
                    break;
                case "/":
                    kq = number1 / Convert.ToDouble(txtNhapPhepTinh.Text);
                    break;
            }
            number1 = kq;
            prevOp = "*"; txtOp.Text = prevOp;
            txtkq.Text = kq.ToString();
            op = true;
        }
        else
        {
            number1 = Convert.ToDouble(txtNhapPhepTinh.Text); kq = number1;
            prevOp = "*"; txtOp.Text = prevOp;
            txtkq.Text = kq.ToString();
            op = true;
        }
    }
    protected void btnchia_Click(object sender, EventArgs e)
    {
        if (prevOp != "")
        {
            switch (prevOp)
            {
                case "+":
                    kq = number1 + Convert.ToDouble(txtNhapPhepTinh.Text);
                    break;
                case "-":
                    kq = number1 - Convert.ToDouble(txtNhapPhepTinh.Text);
                    break;
                case "*":
                    kq = number1 * Convert.ToDouble(txtNhapPhepTinh.Text);
                    break;
                case "/":
                    kq = number1 / Convert.ToDouble(txtNhapPhepTinh.Text);
                    break;
            }
            number1 = kq;
            prevOp = "/"; txtOp.Text = prevOp;
            txtkq.Text = kq.ToString();
            op = true;
        }
        else
        {
            number1 = Convert.ToDouble(txtNhapPhepTinh.Text); kq = number1;
            prevOp = "/"; txtOp.Text = prevOp;
            txtkq.Text = kq.ToString();
            op = true;
        }
    }

    protected void btnbang_Click(object sender, EventArgs e)
    {
        if (prevOp != "")
        {
            switch (prevOp)
            {
                case "+":
                    kq = number1 + Convert.ToDouble(txtNhapPhepTinh.Text);
                    break;
                case "-":
                    kq = number1 - Convert.ToDouble(txtNhapPhepTinh.Text);
                    break;
                case "*":
                    kq = number1 * Convert.ToDouble(txtNhapPhepTinh.Text);
                    break;
                case "/":
                    kq = number1 / Convert.ToDouble(txtNhapPhepTinh.Text);
                    break;
            }
            number1 = 0;
            txtNhapPhepTinh.Text = null;
            txtkq.Text = kq.ToString();
            btnClear_Click(sender,e);
            txtOp.Text = "";
        }
        else
        {
            number1 = 0;
            txtNhapPhepTinh.Text = null;
            txtkq.Text = kq.ToString();
            btnClear_Click(sender, e);
            txtOp.Text = "";
        }
    }
}