using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace university_7b
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String name = TextBox1.Text;
            int age = Convert.ToInt32(TextBox2.Text);
            string mobileNumber = TextBox3.Text;
            string email = TextBox4.Text;
            string address = TextBox5.Text;

            Response.Redirect($"WebForm2.aspx?Name={Server.UrlEncode(name)}&Age={age}&MobileNumber={mobileNumber}&Email={email}&Address={address}");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text = string.Empty;
            TextBox2.Text = string.Empty;
            TextBox3.Text = string.Empty;
            TextBox4.Text = string.Empty;
            TextBox5.Text = string.Empty;
        }
    }
}