using System;
using System.Data.SqlClient;
namespace univeristy5_a
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        protected void ButtonQuery_Click(object sender, EventArgs e)
        {
            BindData();
        }
        private void BindData()
        {
            string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=university;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $"SELECT ID, Name FROM Students WHERE ID = {TextBoxQuery.Text}";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            TextBoxResult.Text += $"{reader["ID"]} {reader["Name"]}" + Environment.NewLine;
                        }
                    }
                }
            }
        }
    }
}
