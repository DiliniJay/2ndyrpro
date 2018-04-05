<%@ WebHandler Language="C#" Class="DrugHandler" %>

using System;
using System.Web;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.Script.Serialization;
using System.Collections.Generic;



public class DrugHandler : IHttpHandler {

    public void ProcessRequest (HttpContext context) {
        string term = context.Request["term"] ?? "";
        List<string> listDrugNames = new List<string>();

        string cs = ConfigurationManager.ConnectionStrings["TestConnectionString"].ConnectionString;
        using(SqlConnection con =new SqlConnection(cs))
        {
            SqlCommand cmd = new SqlCommand("spGetMatchingDrug_names ", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter()
            {
                ParameterName ="@Drugs",
                Value= term
            });
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                    listDrugNames.Add(rdr["Drug_name"].ToString());

            }

        } JavaScriptSerializer js = new JavaScriptSerializer();
            context.Response.Write(js.Serialize(listDrugNames));

    }

    public bool IsReusable {
        get {
            return false;
        }
    }

}