﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalPro
{
    public partial class SwapCardsInHand : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SwapButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("GamePlayPage.aspx");
        }
    }
}