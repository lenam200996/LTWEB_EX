using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cau6 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        for (int i = 1; i < 51; i++)
        {
            if (i % 2 == 0)
            {
                Response.Write("<span style='color:red'>"+i+"</span> ");
            }
            else
            {
                Response.Write("<span style='color:green'>" + i + "</span> ");
            }
        }
    }
}