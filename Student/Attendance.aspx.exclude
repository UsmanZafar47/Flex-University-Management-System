<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Attendance.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>
<html lang="en">

<head>
  <meta charset="UTF-8">
  <meta http-equiv="X-UA-Compatible" content="IE=edge">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <title>Document</title>
  <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.11.7/dist/umd/popper.min.js"
    integrity="sha384-zYPOMqeu1DAVkHiLqWBUTcbYfZ8osu1Nd6Z89ify25QV9guujx43ITvfi12/QExE"
    crossorigin="anonymous"></script>
  <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha3/dist/js/bootstrap.min.js"
    integrity="sha384-Y4oOpwW3duJdCWv5ly8SCFYWqFDsfob/3GkgExXKV4idmbt98QcxXYs9UoXAB7BZ"
    crossorigin="anonymous"></script>
  <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha3/dist/css/bootstrap.min.css" rel="stylesheet"
    integrity="sha384-KK94CHFLLe+nY2dmCWGMq91rCGa5gtU4mk92HdvYe+M/SXH301p5ILy+dN9+nJOZ" crossorigin="anonymous">
  <link rel="stylesheet" type="text/css" href="facultyStyle.css">
</head>

<body>

  <img src="./4.jpg" alt="error" class="theme">
  <nav>
    <ul>
      <li><a href="marks_distribution.html">Marks Distribution</a></li>
      <li><a href="Attendance.aspx">Manage Attendance</a></li>
      <li><a href="evaluation.html">Manage Evaluations</a></li>
      <li><a href="report_grade.html">Generate Grades and Reports</a></li>
      <li><a href="FacultyHome.aspx">HOME</a></li>
    </ul>
  </nav>
  

  


  
   <form runat="server">
       <div class="slect-otions ">
      
		<!-- <select class="form-select container-option" aria-label="Default select example"> -->
		
        <asp:TextBox ID="txtDate" runat="server" CssClass="form-style" TextMode="Date"></asp:TextBox>
            <asp:Button ID="btnSubmitDate" runat="server" Text="Submit" OnClick="btnSubmitDate_Click" />
      
    
		  
      <%--<select class="form-select container-option" aria-label="Default select example">
        <option selected>Section</option>
        <option value="1">E</option>
        <option value="2">F</option>
        <option value="3">D</option>
        </select>--%>
           <div class="dropdown">
                <asp:DropDownList ID="ddlCourses" runat="server" CssClass="form-select container-option" AutoPostBack="true" OnSelectedIndexChanged="ddlCourses_SelectedIndexChanged">
                </asp:DropDownList>
            </div>




          
       
	</div>

         

       <div class="slect-otions">
           
              
            <asp:DropDownList ID="ddlsections" runat="server" CssClass="form-select container-option" AutoPostBack="true" OnSelectedIndexChanged="ddlsections_SelectedIndexChanged">
                
            </asp:DropDownList>
       
       </div>


       <div class="top row ">
        <table class="table container-table">
          <thead class="table-head">
            <tr>
              <th scope="col">#</th>
              <th scope="col">Rollno</th>
              <th scope="col">Name</th>
              <th scope="col">Attendance</th>
            </tr>
          </thead>
          <tbody>
            <asp:Repeater ID="AttendanceRepeater" runat="server">
              <ItemTemplate>
                <tr>
                  <td><%# Container.ItemIndex + 1 %></td>
                  <td><%# Eval("Stid") %></td>
                  <td><%# Eval("SName") %></td>
                  <td>
                    <select class="form-select" aria-label="Default select example" onchange="updateAttendance(this)">
                    <option value="NA">NA</option>
                    <option value="P">P</option>
                    <option value="A">A</option>
                    <option value="L">L</option>
                    </select>
                    <input type="hidden" name="attendance" value="" />
                    </td>
                </tr>
              </ItemTemplate>
            </asp:Repeater>
          </tbody>
        </table>
       </div>
  </form>
  
   
</body>

</html>
