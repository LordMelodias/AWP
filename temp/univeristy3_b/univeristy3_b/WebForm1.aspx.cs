using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace univeristy3_b
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                AdRotator1.KeywordFilter = ""; // Initially, show all ads
            }
        }

        protected void btnFilter_Click(object sender, EventArgs e)
        {
            AdRotator1.KeywordFilter = txtKeyword.Text.Trim();
        }
    }
}