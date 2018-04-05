<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Insert Drugs.aspx.cs" Inherits="Insert_Drugs" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.1//EN" "http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd">
<script runat="server">


</script>

<html xmlns="http://www.w3.org/1999/xhtml" xml:lang="it">
<head>
<title>Prescription</title>
<meta http-equiv="content-type" content="text/html;charset=utf-8" />
<link href="css/style.css" rel="stylesheet" type="text/css" media="all" />
</head>
<body>
<div id="container">
  <div id="header">
    <div id="top"> </div>
    <div id="middle">
      <div id="title">
        <h1>&nbsp;</h1>
      </div>
    </div>
    <div id="down"> </div>
  </div>
  <div id="main">
    <div id="mainleft">
      <div id="contmenu">
        <div id="menu">
          <ul>
            <li><a href="Home.aspx">Home</a></li>
           
            <li><a href="ViewHistory.aspx">View Patient's History</a></li>
            <li><a href="Insert Drugs.aspx">Insert Drugs</a></li>
            
          </ul>
        </div>
      </div>
      <div class="roundcontainer"> <a href="http://www.kykoo.it"></img></a>&nbsp;</div>
      <div class="roundcontainer"> <a href="http://www.kykoo.it"></img></a> &nbsp;</div>
    </div>
      <form id="frm" runat="server">
    <div id="changing">
      <div id="left">
       
         <br/>
           
              <div >  <h3><asp:Label ID="Label2" runat="server" Text="Dr"></asp:Label>  <asp:Label ID="Doctor" runat="server" Text="Namal Gamhewa"></asp:Label><br/>
              <br/><br/><asp:Label ID="Label1" runat="server" Text="Drug"></asp:Label><br/><asp:TextBox ID="Dname" runat="server"></asp:TextBox><br/><br/>
                  <asp:Button ID="Button1" runat="server"  ForeColor="#993300" Font-Bold="true" Text="Insert" OnClick="Button1_Click" />
                  
                  </h3>
                  <h3>
                  
             <br/> </h3>
        </div>   </form>

        <p>&nbsp;</p>
      </div>
      <div id="right">
        
        <p>
            
          </p>
        
      
      </div>
    </div>
  </div>
  <div id="footer"> </div>
</div>
<div ></div>
<div > </div></body>
</html>
