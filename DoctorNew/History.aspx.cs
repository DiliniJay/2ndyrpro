using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

public partial class History : System.Web.UI.Page
{
    
    string docId;
    protected void Page_Load(object sender, EventArgs e)
    {
        ListBox1.Visible = false;
        string email = Session["email"].ToString();
        SqlConnection connn = new SqlConnection(ConfigurationManager.ConnectionStrings["TestConnectionString"].ConnectionString);
        connn.Open();

        String strr = "select patient_name from PatientData where patient_email='" + email + "'"; 
        SqlCommand com2 = new SqlCommand(strr, connn);
        name.Text = com2.ExecuteScalar().ToString();
        connn.Close();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        ListBox1.Items.Clear();
        string email = Session["email"].ToString();
        if (String.IsNullOrEmpty(txtdoc.Text) ){ ScriptManager.RegisterStartupScript(this, this.GetType(), "popup", "alert('select the doctor');", true); }

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["TestConnectionString"].ConnectionString);
        con.Open();

        String st = "select count(*) from Doctor where Doctor_name ='" + txtdoc.Text + "'";
        SqlCommand com = new SqlCommand(st, con);
        int temp = Convert.ToInt32(com.ExecuteScalar().ToString());
        con.Close();
        if(temp==1)

        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["TestConnectionString"].ConnectionString);
            conn.Open();

            String str = "select DoctorId from Doctor where Doctor_name ='" + txtdoc.Text + "'";
            SqlCommand com2 = new SqlCommand(str, conn);


            docId = com2.ExecuteScalar().ToString();
            conn.Close();


            ListBox1.Items.Add(new ListItem(""));
            ListBox1.AppendDataBoundItems = true;
            String strConnString = ConfigurationManager.ConnectionStrings["TestConnectionString"].ConnectionString;
            String strQuery = "SELECT Drug FROM DrugData where  Doctor_Id='" + docId + "' AND patient_email='" + email + "' ";
            String s = "SELECT count(*) FROM DrugData where  Doctor_Id='" + docId + "' AND patient_email='" + email + "' ";
            SqlConnection co = new SqlConnection(strConnString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = strQuery;
            cmd.Connection = con;

            SqlCommand cmdd = new SqlCommand(s, co);
            try
            {
                con.Open();
                ListBox1.DataSource = cmd.ExecuteReader();
                ListBox1.DataTextField = "Drug";

                ListBox1.DataBind();
                ListBox1.Visible = true;

                // con.Open();

                //int temp = Convert.ToInt32(cmdd.ExecuteScalar().ToString());
                //if (temp == 0) { ScriptManager.RegisterStartupScript(this, this.GetType(), "popup", "alert('there is no history');", true); }
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
        else { ScriptManager.RegisterStartupScript(this, this.GetType(), "popup", "alert('Doctor is not recognized');", true); }
    }


    protected void Button2_Click(object sender, EventArgs e)
    {
        Server.Transfer("ViewHistory.aspx");
    }
}