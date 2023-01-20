using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace databasedemo
{
    public class DbConnect 
    {
        //Connection string set in App.Config File
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["SampleDbConnect"].ConnectionString;


        // connection related Methods store in this class
        public void ExecuteNonQuery(string query) // for insert ,Update,delete query
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        public DataTable ExecuteAdapter(string query) //For Select Query
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.Fill(dt);
                return dt;
            }
        }
    }
}
