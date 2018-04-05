<%@ Page Language="C#" AutoEventWireup="true" CodeFile="History.aspx.cs" Inherits="History" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.1//EN" "http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" xml:lang="it">
<head runat="server">
    <title>History</title>
     <script src="jquery-3.2.1.js" type="text/javascript" ></script>
    <script src="jquery-ui.js" type="text/javascript"></script>
<link href="jquery-ui.css" rel="stylesheet" />
   
    <script type="text/javascript">
        $(document).ready(function () {
            $('#txtdoc').autocomplete({
                source: 'DoctorHandler.ashx'

            });

        });


    </script>

	<meta charset="utf-8"/>
	
    

	<!-- Google Fonts -->
	<link href='https://fonts.googleapis.com/css?family=Roboto+Slab:400,100,300,700|Lato:400,100,300,700,900' rel='stylesheet' type='text/css'/>

	<link rel="stylesheet" href="css/animate.css"/>
	<!-- Custom Stylesheet -->
	<link rel="stylesheet" href="css/style1.css"/>

</head>

<body>
     <form id="Form1" runat="server">
	<div class="container">
		<div class="top">
			<h1 id="title" class="hidden"><span id="logo">Medical<span>History of</span></span></h1>
		</div>
		<div class="login-box animated fadeInUp">
			<div class="box-header">
				<h2>
    <asp:Label ID="name" runat="server" Text=""></asp:Label></h2>
			</div>
			<label for="username">Select the doctor</label>
			<br/>
            <asp:TextBox ID="txtdoc" runat="server"></asp:TextBox>
			<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:TestConnectionString %>" SelectCommand="SELECT * FROM [Doctor]"></asp:SqlDataSource>
			<br />
            <asp:Button ID="Button1" BackColor="#665851" FontBold="true" runat="server" Text="Search" ForeColor="White" OnClick="Button1_Click" />
			<br/>

			<label for="History">History</label>
			<br/>
              
    <asp:ListBox ID="ListBox1" runat="server" ></asp:ListBox>
			<br/><br/>
            <asp:Button ID="Button2" BackColor="#665851" runat="server" Text="Log Out" ForeColor="White" OnClick="Button2_Click" />
			<br/>
			<a href="#"><p class="small"></p></a>
		</div>
	</div></form>
</body>


</html>