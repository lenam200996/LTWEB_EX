using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cau5 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        for (int i = 2; i < 10; i++)
        {
            Response.Write("<hr>");
            for (int k = 1; k < 11; k++)
            {
                Response.Write(""+i+"* "+k+" = "+(i * k )+ "<br>");
            }
           
        }
    }
}