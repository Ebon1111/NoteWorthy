﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CeeSharp
{
    public partial class Game : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void LevelSelectBtn_Click(object sender, EventArgs e)
        {
            //Request.QueryString["level"]                
            Response.Redirect("~/InGame");
        }
    }
}