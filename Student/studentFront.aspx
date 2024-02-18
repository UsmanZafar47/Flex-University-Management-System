<%@ Page Language="C#" AutoEventWireup="true" CodeFile="studentFront.aspx.cs" Inherits="_Default" %>










<!DOCTYPE html>
<html>
<head>

	<title>Student|HOME</title>
	<script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.11.7/dist/umd/popper.min.js" integrity="sha384-zYPOMqeu1DAVkHiLqWBUTcbYfZ8osu1Nd6Z89ify25QV9guujx43ITvfi12/QExE" crossorigin="anonymous"></script>
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha3/dist/js/bootstrap.min.js" integrity="sha384-Y4oOpwW3duJdCWv5ly8SCFYWqFDsfob/3GkgExXKV4idmbt98QcxXYs9UoXAB7BZ" crossorigin="anonymous"></script>
<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-KK94CHFLLe+nY2dmCWGMq91rCGa5gtU4mk92HdvYe+M/SXH301p5ILy+dN9+nJOZ" crossorigin="anonymous">	
<link rel="stylesheet" type="text/css" href="homestyle.css">
</head>
<body>
	<img src="./4.jpg" alt="error" class="theme">
    <form runat ="server">
	<nav>
		<ul>
			<li><a href="#">Home</a></li>
			<li><asp:LinkButton ID="AttendanceLink" runat="server" OnClick="AttendanceLink_Click">Attendance</asp:LinkButton></li>
			<li><a href="#">Marks</a></li>
			<li><asp:LinkButton ID="TranscriptLink" runat="server" OnClick="TranscriptLink_Click">Transcript</asp:LinkButton></li>
            <li><a href="#">CGPA Comparison</a></li>


		
		</ul>
	</nav>

        
    <div class="container-std-detail">
		<h3>University Information</h3>
		<ul class="uli">
            <div>
                <li><strong>Roll No:</strong> <asp:Repeater ID="roll" runat="server">
                    <ItemTemplate>
                        <tr>
                            <td>
                                <%# Eval("STID") %>
                            </td>
                        </tr>
                    </ItemTemplate>
                                              </asp:Repeater></li>
                <li><strong>Section</strong><asp:Repeater ID="section" runat="server">
                    <ItemTemplate>
                        <tr>
                            <td>
                                <%# Eval("Parent_Section") %>
                            </td>
                        </tr>
                    </ItemTemplate>
                                              </asp:Repeater></li>
            </div>
            <div>

                <li><strong>Campus</strong>Islamabad</li>
                <li><strong>Degree</strong>  <asp:Repeater ID="degree" runat="server">
                    <ItemTemplate>
                        <tr>
                            <td>
                                <%# Eval("Degree") %>
                            </td>
                        </tr>
                    </ItemTemplate>
                                              </asp:Repeater></li>
            </div>
            <div>
                <li><strong>Batch:</strong>  <asp:Repeater ID="batch" runat="server">
                    <ItemTemplate>
                        <tr>
                            <td>
                                <%# Eval("Batch") %>
                            </td>
                        </tr>
                    </ItemTemplate>
                                              </asp:Repeater></li>
                <li><strong>Status</strong> Current</li>
            </div>
		</ul>
	</div>
    
    <div class="container-std-detail">
		<h3>Person Details</h3>
		<ul class="uli">
            <div>
                <li><strong>Name:</strong> <asp:Repeater ID="name" runat="server">
                    <ItemTemplate>
                        <tr>
                            <td>
                                <%# Eval("Sname") %>
                            </td>
                        </tr>
                    </ItemTemplate>
                                              </asp:Repeater></li>
                <li><strong>Father Name:</strong> Walter Black</li>
            </div>
            <div>

                <li><strong>Address:</strong> 123 Main Street, Anytown, USA</li>
                <li><strong>CNIC:</strong> 12345-6789012-3</li>
                <li><strong>Mobile No:</strong> 555-1234</li>
            </div>
            <div>
                <li><strong>Date of Birth:</strong> January 1, 2000</li>
                <li><strong>Gender:</strong> Male</li>
                <li><strong>Email:</strong> jesse.walter@example.com</li>
            </div>
		</ul>
	</div>


        </form>


</body>
</html>

