using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using System.Data.SqlClient;

namespace RegistrationDemo
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Result.Visible = false;
            Result1.Visible = false;
        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=RegisterDB;Integrated Security=True"))
            {
                con.Open();
                string query = "SELECT COUNT(1) FROM UserLoginSQl WHERE username=@username AND password=@password";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@username", UserText.Text.Trim());
                cmd.Parameters.AddWithValue("@password", PasswordText.Text.Trim());

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count == 1)
                {
                    Result.Visible = true;
                }
                else
                {
                    Result1.Visible = true;
                }
            }
        }
    }
}