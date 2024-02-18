﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Web.UI.HtmlControls;
using static DbProject.Models.commonfn;
using System.Configuration;

public partial class _Default : System.Web.UI.Page
{
    commonfnx fn = new commonfnx();
    string selectedcourse;
    string selectsection;


    string connectionString = "Data Source=DESKTOP-DH9RBN8\\SQLEXPRESS;Initial Catalog=DBproject;Integrated Security=True";
    string st = "INS06";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            PopulateCourseDropdown();
            Populatesections();
            //BindAttendance();
        }

    }


    private void PopulateCourseDropdown()
    {
        using (SqlConnection con = new SqlConnection(connectionString))
        {
            con.Open();
            using (SqlCommand cmd = new SqlCommand("SELECT c.CName FROM courses c INNER JOIN sections s ON c.CID = s.CID WHERE s.IID = @IID", con))
            {
                cmd.Parameters.AddWithValue("@IID", st);
                SqlDataReader reader = cmd.ExecuteReader();
                ddlCourses.DataSource = reader;
                ddlCourses.DataTextField = "CName";
                ddlCourses.DataValueField = "CName";
                ddlCourses.DataBind();
            }
        }

        // Insert the "Select course" option at the beginning
        ListItem selectCourse = new ListItem("Select course", "-1", true);
        ddlCourses.Items.Insert(0, selectCourse);
    }

    protected void btnSubmitDate_Click(object sender, EventArgs e)
    {
        string selectedDate = txtDate.Text;
        string Aid = "A1003";
        string STID = "21i-0600";
        string CID = "MT-1006";
        string SecID = "S-001";
        string Status = "P";

        // Replace the connection string with your own
        string connectionString = "Data Source=DESKTOP-DH9RBN8\\SQLEXPRESS;Initial Catalog=DBproject;Integrated Security=True";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            string query = "INSERT INTO attendance (AID, STID, ADate, CID, SecID, Status) VALUES (@Aid, @STID, @SelectedDate, @CID, @SecID, @Status)";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Aid", Aid);
                command.Parameters.AddWithValue("@STID", STID);
                command.Parameters.AddWithValue("@SelectedDate", selectedDate);
                command.Parameters.AddWithValue("@CID", CID);
                command.Parameters.AddWithValue("@SecID", SecID);
                command.Parameters.AddWithValue("@Status", Status);

                command.ExecuteNonQuery();
            }
        }
    }

    
    
    protected void ddlCourses_SelectedIndexChanged(object sender, EventArgs e)
    {
        selectedcourse = ddlCourses.SelectedValue;
        

        // Handle selected course change here.
    }

    private void Populatesections()
    {
        

        using (SqlConnection con = new SqlConnection(connectionString))
        {
            con.Open();
            using (SqlCommand cmd = new SqlCommand("SELECT SecID from sections where IID=@IID", con))
            {
                cmd.Parameters.AddWithValue("@IID", st);
                SqlDataReader reader = cmd.ExecuteReader();
                ddlsections.DataSource = reader;
                ddlsections.DataTextField = "SecID";
                ddlsections.DataValueField = "SecID";
                ddlsections.DataBind();
            }
        }
        ListItem selectsection = new ListItem("Select section", "-1", true);
        ddlsections.Items.Insert(0, selectsection);
    }
    protected void ddlsections_SelectedIndexChanged(object sender, EventArgs e)
    {
       selectsection= ddlsections.SelectedValue;
        BindAttendance();
    }
     private void BindAttendance()
    {
        // Replace the connection string with your own
        
        string query = "SELECT student.STID, student.SName FROM student INNER JOIN registeredstudents ON student.STID = registeredstudents.STID WHERE registeredstudents.SecID = @SecID";


        using (SqlConnection con = new SqlConnection(connectionString))
        {
            con.Open();
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    cmd.Parameters.AddWithValue("@SecID", selectsection);
                    DataTable attendanceTable = new DataTable();
                    adapter.Fill(attendanceTable);
                    AttendanceRepeater.DataSource = attendanceTable;
                    AttendanceRepeater.DataBind();
                }
            }
        }
    }

}