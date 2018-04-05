<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>

<!DOCTYPE html>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.1//EN" "http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" xml:lang="it">
<head>
<title>Home</title>
   


<meta http-equiv="content-type" content="text/html;charset=utf-8" />
<link href="css/style.css" rel="stylesheet" type="text/css" media="all" />
</head>
<body>

       <form id="frm" runat="server">
<div id="container">
  <div id="header">
    <div id="top"> 
       
          
      </div>
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
   
    <div id="changing">
      <div id="left">
        <div class="flowerlarge">
          <h3>Dr<br/><br/>
              <asp:Label ID="doctor" runat="server" Text=""></asp:Label></h3>
        </div>
       
        <div class="flowerlarge">
          <h3>Patient Count<br/><br/>
              <asp:Label ID="count" runat="server" Text=""  Font-Names="Verdana" ForeColor="#663333"></asp:Label></h3>
     </div> 
           <div class="flowerlarge">
          <h3>Appointments in <br/><br/><asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True"  OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"  Font-Bold="True" Font-Names="Verdana" ForeColor="#663333"  ></asp:DropDownList>
               </h3>
               <p>&nbsp;</p><br/>
               
               
             
               <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:TestConnectionString %>" DeleteCommand="DELETE FROM [Patient_data] WHERE [Appointment no] = @Appointment_no" InsertCommand="INSERT INTO [Patient_data] ([Appointment no], [medical_center], [Consultant], [patient_id], [patient_email], [consultant_id]) VALUES (@Appointment_no, @medical_center, @Consultant, @patient_id, @patient_email, @consultant_id)" SelectCommand="SELECT * FROM [Patient_data]" UpdateCommand="UPDATE [Patient_data] SET [medical_center] = @medical_center, [Consultant] = @Consultant, [patient_id] = @patient_id, [patient_email] = @patient_email, [consultant_id] = @consultant_id WHERE [Appointment no] = @Appointment_no">
                   <DeleteParameters>
                       <asp:Parameter Name="Appointment_no" Type="String" />
                   </DeleteParameters>
                   <InsertParameters>
                       <asp:Parameter Name="Appointment_no" Type="String" />
                       <asp:Parameter Name="medical_center" Type="String" />
                       <asp:Parameter Name="Consultant" Type="String" />
                       <asp:Parameter Name="patient_id" Type="String" />
                       <asp:Parameter Name="patient_email" Type="String" />
                       <asp:Parameter Name="consultant_id" Type="String" />
                   </InsertParameters>
                   <UpdateParameters>
                       <asp:Parameter Name="medical_center" Type="String" />
                       <asp:Parameter Name="Consultant" Type="String" />
                       <asp:Parameter Name="patient_id" Type="String" />
                       <asp:Parameter Name="patient_email" Type="String" />
                       <asp:Parameter Name="consultant_id" Type="String" />
                       <asp:Parameter Name="Appointment_no" Type="String" />
                   </UpdateParameters>
               </asp:SqlDataSource>
             
        </div><br/><br/><br/>
          
         
              <div>
                  <asp:Label ID="Label1" runat="server" Text="" Font-Names="Verdana" ForeColor="#663333"></asp:Label>
                  </div>
              <asp:ListBox ID="ListBox1" runat="server" AutoPostBack="True"  Font-Names="Verdana" ForeColor="#663333" ></asp:ListBox>
       
          <br/> 
          <asp:Button ID="Button1" runat="server" Text="Prescribe" Height="28px" style="margin-left: 36px" Font-Names="Verdana" ForeColor="#663333"   Width="103px" Font-Bold="True" OnClick="Button1_Click"/>
           
             
           
               </div>

        <p>&nbsp;</p>
      </div>
      <div id="right">
        
        
        
      
      </div>
    </div>
  </div>
  <div id="footer"> </div>
</div>
<div ></div>
<div > </div>
           <asp:SqlDataSource ID="SqlDataSource2" runat="server"></asp:SqlDataSource>
           <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:TestConnectionString %>" SelectCommand="SELECT * FROM [PatientData]"></asp:SqlDataSource>
           
             
           
               </form>

        </body>
</html>
