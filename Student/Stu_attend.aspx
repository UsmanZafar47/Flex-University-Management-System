<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Stu_attend.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>
<html lang="en">

<head>
    <style>
        .center {
            margin: auto;
            width: 50%;
        }
    </style>
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
  <link rel="stylesheet" type="text/css" href="homestyle.css">
</head>

<body>
      <form id="form1" runat="server">
	<img src="./4.jpg" alt="error" class="theme">
	<nav>
		<ul>
			<li><asp:LinkButton ID="HomeLink" runat="server" OnClick="HomeLink_Click">Home</asp:LinkButton></li>
			<li><a href="#">Attendance</a></li>
			<li><a href="./marks.html">Marks</a></li>
			<li><a href="./transcript.html">Transcript</a></li>
            <li><a href="#">CGPA Comparison</a></li>

		
		</ul>
    </nav>


<div class="select-options">
    <asp:DropDownList ID="ddlCourse" runat="server" CssClass="form-select container-option" AutoPostBack="True" OnSelectedIndexChanged="ddlCourse_SelectedIndexChanged">
        <asp:ListItem Selected="True" Value="">Course</asp:ListItem>
        <asp:ListItem Value="'CS-2005'"> DATA</asp:ListItem>
        <asp:ListItem Value="'CS-1005'"> OOP</asp:ListItem>
        <asp:ListItem Value="'CS-1000'">PF</asp:ListItem>
    </asp:DropDownList>
</div>
          


      
      <div class="center">
        <asp:GridView ID="GridView1" runat="server"  Width="800px" Height="400px"></asp:GridView>
      </div>
</form>
</body>

</html>