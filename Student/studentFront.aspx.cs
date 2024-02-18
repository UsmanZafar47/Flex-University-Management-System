using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.Razor.Generator;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Runtime.InteropServices;

public partial class _Default : System.Web.UI.Page
{
   public string Func(string str)
    {
        string j = "'";
        for (int i = 0; i < str.Length; i++)
            j += str[i];
        j += "'";
        return j;
    }
    string user;
    protected void AttendanceLink_Click(object sender, EventArgs e)
    {
        Response.Redirect("Stu_attend.aspx?id="+user);
    }
    protected void TranscriptLink_Click(object sender, EventArgs e)
    {
        Response.Redirect("Stu_transcript.aspx?id=" + user);
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        string id="";
        if (Request.QueryString["id"] != null)
        {
            id = Request.QueryString["id"];
            // use the value of name as needed
        }

        id = Func(id);
        user = id;

        rollnum(id);
        p_section(id);
        degreeFunc(id);
        batchFunc(id);
        nameFunc(id);
    }
    string rr = "'21i-0001'";
    public void rollnum(string id)
    {
        string connectionString = "Data Source=DESKTOP-6UEJMIF\\SQLEXPRESS01;Initial Catalog=DB_Project;Integrated Security=True";
        string query = "SELECT stid FROM student WHERE stid = " + id;


        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable frontPage = new DataTable();
                    adapter.Fill(frontPage);
                    roll.DataSource = frontPage;
                    roll.DataBind();
                }
            }
        }
    }


    public void p_section(string id)
    {
        string connectionString = "Data Source=DESKTOP-6UEJMIF\\SQLEXPRESS01;Initial Catalog=DB_Project;Integrated Security=True";
        string query = "SELECT Parent_Section FROM student WHERE stid = "+id;


        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable frontPage = new DataTable();
                    adapter.Fill(frontPage);
                    section.DataSource = frontPage;
                    section.DataBind();
                }
            }
        }
    }

    public void degreeFunc(string id)
    {
        string connectionString = "Data Source=DESKTOP-6UEJMIF\\SQLEXPRESS01;Initial Catalog=DB_Project;Integrated Security=True";
        string query = "SELECT Degree FROM student WHERE stid = "+id;


        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable frontPage = new DataTable();
                    adapter.Fill(frontPage);
                    degree.DataSource = frontPage;
                    degree.DataBind();
                }
            }
        }
    }

    public void batchFunc(string id)
    {
        string connectionString = "Data Source=DESKTOP-6UEJMIF\\SQLEXPRESS01;Initial Catalog=DB_Project;Integrated Security=True";
        string query = "SELECT Batch FROM student WHERE stid = "+id;


        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable frontPage = new DataTable();
                    adapter.Fill(frontPage);
                    batch.DataSource = frontPage;
                    batch.DataBind();
                }
            }
        }
    }
    public void nameFunc(string id)
    {
        string connectionString = "Data Source=DESKTOP-6UEJMIF\\SQLEXPRESS01;Initial Catalog=DB_Project;Integrated Security=True";
        string query = "SELECT Sname FROM student WHERE stid = "+id;


        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable frontPage = new DataTable();
                    adapter.Fill(frontPage);
                    name.DataSource = frontPage;
                    name.DataBind();
                }
            }
        }
    }
}