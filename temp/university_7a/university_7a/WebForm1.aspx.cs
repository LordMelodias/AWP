using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace university_7a
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Page1Visits"] == null)
            {
                // If it doesn't exist, initialize it to 1
                Session["Page1Visits"] = 1;
            }
            else
            {
                // If it exists, increment it by 1
                Session["Page1Visits"] = (int)Session["Page1Visits"] + 1;
            }

            // Display the number of visits on the page
            int page1Visits = (int)Session["Page1Visits"];
            Label1.Text = "Number of Visits to Page : " + page1Visits.ToString();
        }
    }
}