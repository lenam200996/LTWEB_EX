﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cau2_Home : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Write("<script>alert('Welcome to my website!')</script>");
    }


    public void Page_Unload(object sender, EventArgs e)
    {

        
    }
}