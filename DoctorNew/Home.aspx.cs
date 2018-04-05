using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

public partial class Home : System.Web.UI.Page
{
    



    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        
        Label1.Text = DropDownList1.SelectedItem.Text;
        ListBox1.Items.Clear();

        ListBox1.Items.Add(new ListItem(""));
        ListBox1.AppendDataBoundItems = true;
        String strConnnString = ConfigurationManager.ConnectionStrings["TestConnectionString"].ConnectionString;
        //String strrQuery = "select distinct patient_name from PatientData where  Doctor_id='658573318v' AND Medical_center='" + Label1.Text + "'";
        SqlConnection conn = new SqlConnection(strConnnString);
        SqlCommand comd = new SqlCommand("select distinct patient_name from PatientData where  Doctor_id='658573318v' AND Medical_center='" + Label1.Text + "'", conn);
        
       // comd.CommandType = CommandType.Text;
       // comd.CommandText = strrQuery;
       // comd.Connection = conn;
        String str = "select count(*) from  PatientData where  Doctor_id='658573318v' AND Medical_center='" + DropDownList1.SelectedItem.Text + "'";

        try
        {
            conn.Open();
            SqlCommand com = new SqlCommand(str, conn);
            int temp = Convert.ToInt32(com.ExecuteScalar().ToString());
            ListBox1.DataSource = comd.ExecuteReader();
            ListBox1.DataTextField = "patient_name";

            ListBox1.DataBind();
            ListBox1.Visible = true;
            count.Text = temp.ToString();
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            conn.Close();
            conn.Dispose();
        }

    }
   



    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ListBox1.Visible = false;
            DropDownList1.Items.Add(new ListItem("Select the medical center", ""));
            DropDownList1.AppendDataBoundItems = true;
            String strConnString = ConfigurationManager.ConnectionStrings["TestConnectionString"].ConnectionString;
            String strQuery = "select distinct Medical_center	 from PatientData where Doctor_id ='658573318v'  ";
            SqlConnection con = new SqlConnection(strConnString);
            SqlCommand cmd = new SqlCommand(strQuery,con);
           // cmd.CommandType = CommandType.Text;
           // cmd.CommandText = strQuery;
           // cmd.Connection = con;
            String sttr = "select distinct Doctor_name from PatientData where Doctor_id ='658573318v'  ";

            try
            {
                con.Open();
                SqlCommand com = new SqlCommand(sttr, con);
                string tempp  =(com.ExecuteScalar().ToString());
                DropDownList1.DataSource = cmd.ExecuteReader();
                DropDownList1.DataTextField = "Medical_Center";
                doctor.Text = tempp;

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

       

    }
   



    protected void Button1_Click(object sender, EventArgs e)
    {
        if (String.IsNullOrEmpty(DropDownList1.Text))
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "popup", "alert('Select the medcal center');", true);

        }
      else  if (this.ListBox1.SelectedIndex == -1)
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "popup", "alert('Select the patient');", true);

        }
        else
        {
            Session["patient"] = ListBox1.SelectedItem.ToString();
            Session["Mcenter"] = DropDownList1.SelectedItem.Text;

            Server.Transfer("Prescription.aspx");
        }
    }
}