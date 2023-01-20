using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Collections;
using System.Data.SqlClient;
using System.Data;
using System.Collections;
/// <summary>
/// Summary description for connect
/// </summary>
public class connect
{
    SqlDataAdapter adt;
    DataSet ds;
    SqlConnection cn;
    SqlCommand cnd;
    ArrayList list;
    SqlDataReader dr;

    public void execute(string str)
    {
        cnd = new SqlCommand(str, cn);
        cn.Open();
        cnd.ExecuteNonQuery();
        cn.Close();
    }
	public connect()
	{
        cn = new SqlConnection();
        //cn.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\job.mdf;Integrated Security=True;User Instance=True";
        cn.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True;User Instance=True";
		//
		// TODO: Add constructor logic here
		//
	}
}