using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace university6_b
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Load data on the first page load
                LoadData();
            }
        }

        
        private void LoadData()
        {
            string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=university;Integrated Security=True";
            string query = "SELECT * FROM Students";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataSet dataSet = new DataSet();

                adapter.Fill(dataSet, "Students");

                // Bind the data to the GridView
                GridView1.DataSource = dataSet.Tables["Students"];
                GridView1.DataBind();
            }
        }
    }
}