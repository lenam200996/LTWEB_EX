using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cau2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        DateTime date = DateTime.Now;
        int yeah = date.Year;
        Response.Write("<b style='color:red'><u>Age: " + (yeah - Convert.ToInt32(TextBox3.Text))+"</u><b>");
    }
}