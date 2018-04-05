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
public partial class Insert_Drugs : System.Web.UI.Page
{
    string docId;
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["TestConnectionString"].ConnectionString);
        conn.Open();
        String str1 = "select DoctorId from Doctor where Doctor_name ='" + Doctor.Text + "'";

        SqlCommand com = new SqlCommand(str1, conn);
        docId = com.ExecuteScalar().ToString();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (String.IsNullOrEmpty(Dname.Text)) { ScriptManager.RegisterStartupScript(this, this.GetType(), "popup", "alert('Insert Drug Name');", true); }
        else
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["TestConnectionString"].ConnectionString);
             con.Open();
            string st = "select count(*) from Drugs where Drug_name='" + Dname.Text + "'";
            SqlCommand comm = new SqlCommand(st, con);
            int temp = Convert.ToInt32(comm.ExecuteScalar().ToString());
            if (temp == 0)
            {


                try
                {

                    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["TestConnectionString"].ConnectionString);
                    conn.Open();
                    String insertQ = "insert into Drugs values (@docId,@drug)";
                    SqlCommand com = new SqlCommand(insertQ, conn);


                    com.Parameters.AddWithValue("@docId", docId);

                    com.Parameters.AddWithValue("@drug", Dname.Text);


                    com.ExecuteNonQuery();//

                    conn.Close();




                }
                catch (Exception ex)
                {
                    Response.Write(ex.ToString());
                    Response.Write("<script>alert('New drug was inserted')</script>");
                    // ScriptManager.RegisterStartupScript(this, this.GetType(), "popup", "alert('Incorrect password');", true);
                }
                Response.Write("<script>alert('Data inserted successfully')</script>");
                Dname.Text = String.Empty;
            }else { ScriptManager.RegisterStartupScript(this, this.GetType(), "popup", "alert(' Already exsist drug');", true); }
        }
    }

}
