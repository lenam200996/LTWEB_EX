using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cau8 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
 
  
    protected void txtNum_TextChanged(object sender, EventArgs e)
    {
        switch (Convert.ToInt32(txtNum.Text))
        {
            case 1:
                Response.Redirect("http://www.vinhuni.edu.vn");
                break;
            case 2:
                Response.Redirect("https://nghean.gov.vn");
                break;
            case 3:
                Response.Redirect("http://www.microsoft.com");
                break;
            default:
                Response.Redirect("https://google.com");
                break;
        }
    }
}