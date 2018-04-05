<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Prescription.aspx.cs" Inherits="Prescription" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.1//EN" "http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" xml:lang="it">
<head runat="server">
<title>Prescription</title> 
    <script src="jquery-3.2.1.js" type="text/javascript" ></script>
    <script src="jquery-ui.js" type="text/javascript"></script>
    <link href="jquery-ui.css" rel="stylesheet" />
    <script type="text/javascript">
        $(document).ready(function () {
            $('#txtDrug').autocomplete({
                source :'DrugHandler.ashx'

            });

        });
    

    </script>


<meta http-equiv="content-type" content="text/html;charset=utf-8" />
<link href="css/style.css" rel="stylesheet" type="text/css" media="all" />
</head>
<body>
<div id="container">
  <div id="header">
    <div id="top"> </div>
    <div id="middle">
      <div id="title">
        <h1>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:TestConnectionString %>" SelectCommand="SELECT * FROM [Drugs]"></asp:SqlDataSource>
          </h1>
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
        <div class="flowerlarge">
          <h3>Doctor<br/><br/>
              <asp:Label ID="doctor" runat="server" Text="Namal Gamhewa"></asp:Label></h3>
        </div>
       
        <div class="flowerlarge">
          <h3>Patient <br/><br/>
              <asp:TextBox ID="patient" runat="server" Font-Names="Verdana" ForeColor="#663333"></asp:TextBox></h3>
            
     </div> 
           <div class="flowerlarge">
          <h3>Medical Center<br/><br/>
              <asp:Label ID="Mcenter" runat="server" Text="" Font-Names="Verdana" ForeColor="#663333"></asp:Label></h3>
        </div><br/>
          <div 
          <asp:Label ID="Label2" color="#993300" Font-Names="Verdana" ForeColor="#663333"  runat="server" Text="Date"></asp:Label><br/>
              <asp:Label ID="Date" color="#993300" Font-Names="Verdana" ForeColor="#663333"  runat="server" Text=""></asp:Label>
        </div>
        
              <div >  <h3><asp:Label ID="t" runat="server" Text="Drug"></asp:Label><br/>
              <asp:TextBox ID="txtDrug" runat="server" Font-Names="Verdana" ForeColor="#663333"></asp:TextBox>
                  <br/><br/><asp:Label ID="Label1" runat="server" Text="Dosage"></asp:Label><br/><asp:TextBox ID="Dosage" runat="server" Font-Names="Verdana" ForeColor="#663333"></asp:TextBox>
                  <asp:Button ID="Button1" runat="server" Height="28px" style="margin-left: 36px" Font-Names="Verdana" ForeColor="#663333"  Text="Prescribe" Width="103px" OnClick="Button1_Click1" Font-Bold="True" />
            <div>
                </div>
        </div>   </form>
      </div>

        
  
    </div>
  </div>
  <div id="footer"> </div>
</div>
<div ></div>
<div > </div></body>
</html>
