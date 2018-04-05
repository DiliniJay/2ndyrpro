<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ViewHistory.aspx.cs" Inherits="ViewHistory" %>

<!DOCTYPE html>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<!DOCTYPE html>
<script runat="server">

    
</script>

<html lang="en">

<head>
	<meta charset="utf-8">
	<title>View History</title>

	<!-- Google Fonts -->
	<link href='https://fonts.googleapis.com/css?family=Roboto+Slab:400,100,300,700|Lato:400,100,300,700,900' rel='stylesheet' type='text/css'>

	<link rel="stylesheet" href="css/animate.css">
	<!-- Custom Stylesheet -->
	<link rel="stylesheet" href="css/style1.css">

	<script src="https://ajax.googleapis.com/ajax/libs/jquery/2.1.4/jquery.min.js"></script>
</head>

<body>
   <form id="frm" runat="server">
	<div class="container">
		<div class="top">
			<h1 id="title" class="hidden"><span id="logo">Medical<span>History View</span></span></h1>
		</div>
		<div class="login-box animated fadeInUp">
			<div class="box-header">
				<h2>Log In</h2>
			</div>
			<label for="username">E mail</label>
			<br/>
            <asp:TextBox ID="email" runat="server"></asp:TextBox>
			<br/>
			<label for="password">Password</label>
			<br/>
            <asp:TextBox ID="password" runat="server" TextMode="Password"></asp:TextBox>
			<br/>
            <asp:Button ID="Button1" runat="server" Text="VIEW" BackColor="#665851" ForeColor="White" OnClick="Button1_Click" />
			
			<br/>
			<a href="#"></a>
		</div>
	</div>
       </form>
</body>

<script>
	$(document).ready(function () {
    	$('#logo').addClass('animated fadeInDown');
    	$("input:text:visible:first").focus();
	});
	$('#username').focus(function() {
		$('label[for="username"]').addClass('selected');
	});
	$('#username').blur(function() {
		$('label[for="username"]').removeClass('selected');
	});
	$('#password').focus(function() {
		$('label[for="password"]').addClass('selected');
	});
	$('#password').blur(function() {
		$('label[for="password"]').removeClass('selected');
	});
</script>

</html>
</html>
