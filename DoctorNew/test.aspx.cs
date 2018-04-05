using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

public partial class test : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DropDownList1.Items.Add(new ListItem("", ""));
            DropDownList1.AppendDataBoundItems = true;
            string str = ConfigurationManager.ConnectionStrings["TestConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(str);
            SqlCommand com = new SqlCommand("select distinct Medical_center	 from PatientData where Doctor_id ='658573318v'", con);

            try
            {
                con.Open();
                DropDownList1.DataSource = com.ExecuteReader();
                DropDownList1.DataTextField = "Medical_center";
                DropDownList1.DataBind();
            }
            catch (Exception ex) { throw ex; }
            finally { con.Close(); con.Dispose(); }
        }
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        ListBox1.Items.Clear();
        ListBox1.Items.Add(new ListItem("",""));
        ListBox1.AppendDataBoundItems = true;
        string st = ConfigurationManager.ConnectionStrings["TestConnectionString"].ConnectionString;
        SqlConnection con = new SqlConnection(st);
        SqlCommand com = new SqlCommand("select distinct Medical_center from PatientData where Doctor_id ='658573318v'  ", con);
        try
        { con.Open();
            ListBox1.DataSource =com.ExecuteReader();
            ListBox1.DataTextField ="Medical_center";
            ListBox1.DataBind();
        }
        catch(Exception ex)
        { throw ex; }
        finally {
            con.Close();
            con.Dispose();
        }
        

    }
}