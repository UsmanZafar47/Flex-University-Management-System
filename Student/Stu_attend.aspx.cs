using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class _Default : System.Web.UI.Page
{

    //protected void Page_Load(object sender, EventArgs e)
    //{
    //    string id = "";
    //    if (Request.QueryString["id"] != null)
    //    {
    //        id = Request.QueryString["id"];
    //        // use the value of name as needed
    //    }
    //    string connectionString = "Data Source=DESKTOP-6UEJMIF\\SQLEXPRESS01;Initial Catalog=DB_Project;Integrated Security=True";
    //    string selectQuery = "SELECT * FROM Attendance ";
    //    SqlConnection connection = new SqlConnection(connectionString);
    //    SqlCommand command = new SqlCommand(selectQuery, connection);
    //    SqlDataAdapter adapter = new SqlDataAdapter(command);
    //    DataSet dataSet = new DataSet();
    //    adapter.Fill(dataSet);
    //    GridView1.DataSource = dataSet;
    //    GridView1.DataBind();
    //}
    string idd = "";
    public string fixIt(string i)
    {
        string x="";
        for(int j = 0; j < i.Length; j++)
        {
            if (i[j] != '\'')
            {
                x += i[j];
            }
                
        }
        return x;
    }
    protected void HomeLink_Click(object sender, EventArgs e)
    {
        Response.Redirect("StudentFront.aspx?id=" + fixIt(idd));
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        string id = "";
        if (Request.QueryString["id"] != null)
        {
            id = Request.QueryString["id"];
            idd = id;
            // use the value of name as needed
        }
        if (!IsPostBack)
        {
            // Populate the course dropdown
            if (ddlCourse.Items.Count == 0)
            {
                ddlCourse.Items.Add(new ListItem("Course", ""));
                ddlCourse.Items.Add(new ListItem("DATA", "'CS-2005'"));
                ddlCourse.Items.Add(new ListItem("OOP", "'CS-1005'"));
                ddlCourse.Items.Add(new ListItem("PF", "'CS-1000'"));
            }
        }
    }
    protected void ddlCourse_SelectedIndexChanged(object sender, EventArgs e)
    {
        string course = ddlCourse.SelectedValue;
        string selectQuery = "";
        if (idd != "")
        {
            if (course == "'CS-2005'")
            {
                selectQuery = "SELECT Adate,Status FROM Attendance WHERE CID='CS-2005' and stid="+idd;
            }
            else if (course == "'CS-1005'")
            {
                selectQuery = "SELECT Adate,Status FROM Attendance WHERE CID='CS-1005' and stid=" + idd;
            }
            else if (course == "'CS-1000'")
            {
                selectQuery = "SELECT Adate,Status FROM Attendance WHERE CID='CS-1000' and stid=" + idd;
            }
            else
            {
                selectQuery = "Select* from Attendance";
            }
        }
        // Retrieve the data from the database
        string connectionString = "Data Source=DESKTOP-6UEJMIF\\SQLEXPRESS01;Initial Catalog=DB_Project;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connectionString);
        SqlCommand command = new SqlCommand(selectQuery, connection);
        SqlDataAdapter adapter = new SqlDataAdapter(command);
        DataSet dataSet = new DataSet();
        adapter.Fill(dataSet);

        // Bind the data to the gridview
        GridView1.DataSource = dataSet;
        GridView1.DataBind();
    }


}