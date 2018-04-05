using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Input;

public partial class Prescription : System.Web.UI.Page
{
    string docId, pname, pemail;
    protected void Page_Load(object sender, EventArgs e)
    {
        patient.Text = Session["patient"].ToString();
             Mcenter.Text = Session["Mcenter"].ToString();
        Date.Text = System.DateTime.Today.ToString("dd/MM/yy");
       // if (!IsPostBack)
      //  {
            


         /*   DropDownList1.Items.Add(new ListItem("Select the medical center", ""));
            DropDownList1.AppendDataBoundItems = true;
            String strConnString = ConfigurationManager.ConnectionStrings["TestConnectionString"].ConnectionString;
            String strQuery = "select Appointment_no, Medical_center from PatientData where Doctor_id ='658573318v'  ";
            SqlConnection con = new SqlConnection(strConnString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = strQuery;
            cmd.Connection = con;


            try
            {
                con.Open();
                DropDownList1.DataSource = cmd.ExecuteReader();
                DropDownList1.DataTextField = "Medical_Center";
                DropDownList1.DataValueField = "Appointment_no";
                DropDownList1.DataBind();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
        }
        */

       




    }

    /////////////////////////////////////////////////////////////

  





    protected void Button1_Click1(object sender, EventArgs e)
    {
        SqlConnection co = new SqlConnection(ConfigurationManager.ConnectionStrings["TestConnectionString"].ConnectionString);
        co.Open();
        String st = "select count(*) from Drugs where Drug_name ='" + txtDrug.Text + "'";
        SqlCommand cm = new SqlCommand(st, co);
         int temp = Convert.ToInt32(cm.ExecuteScalar().ToString());

        //if (String.IsNullOrEmpty(patient.Text)) { ScriptManager.RegisterStartupScript(this, this.GetType(), "popup", "alert('Enter patient ID');", true); }
      //  else if (String.IsNullOrEmpty(DropDownList1.Text)) { ScriptManager.RegisterStartupScript(this, this.GetType(), "popup", "alert('Select the medcal center');", true); }
         if (String.IsNullOrEmpty(txtDrug.Text)) { ScriptManager.RegisterStartupScript(this, this.GetType(), "popup", "alert('Enter the drug name');", true); }
         else if(temp==0) { ScriptManager.RegisterStartupScript(this, this.GetType(), "popup", "alert('Drug is not recognized');", true); }
        else if (String.IsNullOrEmpty(Dosage.Text)) { ScriptManager.RegisterStartupScript(this, this.GetType(), "popup", "alert('Enter the Dosage');", true); }

 
        else
        {

            
                //  if (String.IsNullOrEmpty(patient.Text)) { ScriptManager.RegisterStartupScript(this, this.GetType(), "popup", "alert('Enter patient ID');", true); }

                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["TestConnectionString"].ConnectionString);
                conn.Open();

            //String strr = "select count(*) from PatientData where PatientId ='" + patient.Text + "'";
           

            String str = "select patient_email from PatientData where Patient_name ='" + patient.Text + "'";
                SqlCommand com2 = new SqlCommand(str, conn);

                String str1 = "select DoctorId from Doctor where Doctor_name ='" + doctor.Text + "'";

                SqlCommand comm = new SqlCommand(str1, conn);
                docId = comm.ExecuteScalar().ToString();

                SqlDataReader reader = com2.ExecuteReader();
                reader.Read();

                pemail = reader["patient_email"].ToString();
                conn.Close();






           
            try
            {

                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["TestConnectionString"].ConnectionString);
                conn.Open();
                String insertQ = "insert into DrugData values (@pId,@mcenter,@docId,@pemail,@date,@drug,@dosage)";
                SqlCommand com = new SqlCommand(insertQ, conn);

                com.Parameters.AddWithValue("@pId", patient.Text);
                com.Parameters.AddWithValue("@mcenter",Mcenter.Text);
                com.Parameters.AddWithValue("@docId", docId);

                com.Parameters.AddWithValue("@pemail", pemail);
                com.Parameters.AddWithValue("@date", Date.Text);

                com.Parameters.AddWithValue("@drug", txtDrug.Text);

                com.Parameters.AddWithValue("@dosage", Dosage.Text);

                com.ExecuteNonQuery();//

                conn.Close();




            }
            catch (Exception ex)
            {
                Response.Write(ex.ToString());
                Response.Write("<script>alert('Data inserted unsuccessfully')</script>");

            }
            Response.Write("<script>alert('Drug was prescribed')</script>");
            txtDrug.Text = String.Empty;
            Dosage.Text = String.Empty;
        }
    }

}

