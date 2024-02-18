using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-DH9RBN8\\SQLEXPRESS;Initial Catalog=DBproject;Integrated Security=True");
            conn.Open();
            SqlCommand cm;
            string un = RollNoTextBox.Text;
            string pass = PasswordTextBox.Text;
            string query = "SELECT Ponch FROM SuperUser WHERE userid = '" + un + "' AND pass = '" + pass + "'";

            cm = new SqlCommand(query, conn);
            SqlDataReader reader = cm.ExecuteReader();
           
           

            if (reader.HasRows)
            {
                reader.Read();
                string role = reader.GetString(0);
                if (role == "I")
                {
                    Response.Redirect("FacultyHome.aspx?un=" + un);
                }
              
            }
           //  cm.ExecuteNonQuery();
            cm.Dispose();
            conn.Close();
        }
    }
}