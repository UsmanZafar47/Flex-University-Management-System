<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FacultyHome.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html>
<html>
<head>

	<title>Faculty|HOME</title>
	<script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.11.7/dist/umd/popper.min.js" integrity="sha384-zYPOMqeu1DAVkHiLqWBUTcbYfZ8osu1Nd6Z89ify25QV9guujx43ITvfi12/QExE" crossorigin="anonymous"></script>
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha3/dist/js/bootstrap.min.js" integrity="sha384-Y4oOpwW3duJdCWv5ly8SCFYWqFDsfob/3GkgExXKV4idmbt98QcxXYs9UoXAB7BZ" crossorigin="anonymous"></script>
<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-KK94CHFLLe+nY2dmCWGMq91rCGa5gtU4mk92HdvYe+M/SXH301p5ILy+dN9+nJOZ" crossorigin="anonymous">	
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
	
	<div class="slect-otions">
		<select class="form-select container-option" aria-label="Default select example">
			<option selected>(CAMPUS)</option>
			<option value="1">Islamabad</option>
			<option value="2">Lahore</option>
			<option value="3">Peshawar</option>
		  </select>
		  <select class="form-select container-option" aria-label="Default select example">
			<option selected>(Smester)</option>
			<option value="1"> Fall 2020</option>
			<option value="2"> spring 2020</option>
			<option value="3">fall 2021</option>
		  </select>
		  <form class="d-flex" role="search">
			<input class="form-control me-2" type="search" placeholder="Search" aria-label="Search">
			<button class="btn btn-outline-primary" type="submit">Search</button>
		  </form>
	</div>

		<div>
			<table class="table container-table" >
				<thead class="table-head">
				  <tr>
					<th scope="col">#</th>
					<th scope="col">Offered Courses</th>
					<th scope="col">Section</th>
					<th scope="col">Teacher</th>
				  </tr>
				</thead>
				<tbody class="table-group-divider">
				  <tr>
					<th scope="row">1</th>
					<td>DATA Structure</td>
					<td>E</td>
					<td>DAWG</td>
				  </tr>
				  <tr>
					<th scope="row">2</th>
					<td>PF</td>
					<td>D</td>
					<td>BITCH</td>
				  </tr>
				  <tr>
					<th scope="row">3</th>
					<td >OOP</td>
					<td>E</td>
					<td> JESSE PINKMAN </td>
				  </tr>
				</tbody>
			  </table>

		</div>
</body>
</html>
