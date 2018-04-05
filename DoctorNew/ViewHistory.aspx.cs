using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;



public partial class ViewHistory : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }





    protected void Button1_Click(object sender, EventArgs e)
    {
        if (String.IsNullOrEmpty(email.Text))
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "popup", "alert('Insert email');", true);

        }
        if (String.IsNullOrEmpty(password.Text))
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "popup", "alert('Insert password');", true);

        }


        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["TestConnectionString"].ConnectionString);
        conn.Open();

        String str = "select count(*) from Patient where Patient_email ='" + email.Text + "'";

        SqlCommand com = new SqlCommand(str, conn);
        int temp = Convert.ToInt32(com.ExecuteScalar().ToString());

        if (temp == 1)
        {

            string checkPasswordQuery = "select password from Patient where  Patient_email ='" + email.Text + "'";
            SqlCommand passComm = new SqlCommand(checkPasswordQuery, conn);

            string pass = passComm.ExecuteScalar().ToString();
            if (pass == password.Text)
            {




                conn.Close();

                Session["email"] = email.Text;
               

                Server.Transfer("History.aspx");
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "popup", "alert('Incorrect password');", true);
            }






        }
        else
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "popup", "alert('Incorrect Email');", true);


        }
    }
}
