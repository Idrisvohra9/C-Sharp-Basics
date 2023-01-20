using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using System.Data.SqlClient;
namespace projectdemo
{
   public class Connection
    {
       SqlCommand cnd;
       SqlConnection cn;
       public Connection()
       {
           //Create Instance of SqlConnection

           SqlConnection cn = new SqlConnection();
           //now you can set ConnectionString property for myConnection

         //  cn.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Database1.sdf;Integrated Security=True;User Instance=True";
           cn.ConnectionString = @"Data Source=DESKTOP-PC\SQLEXPRESSC:\Users\hello\Desktop\C#\program\projectdemo\projectdemo\Database1.sdf;Integrated Security=True;User Instance=True";
           cn.Open();

          // Console.WriteLine();

           Console.WriteLine("The connection was just opened");

           Console.WriteLine();
       }
       public void execute(string str)
       {
           cnd = new SqlCommand(str, cn);
           cn.Open();
           cnd.ExecuteNonQuery();
           cn.Close();
       }
   }
       public class Interface1
       {

           public void Display()
           {

               string Address;

               string Name;

               Console.WriteLine("Enter the Employee Name");

               Name = Console.ReadLine();

               Console.WriteLine();

               Console.WriteLine("Enter the Employee Address");

               Address = Console.ReadLine();

               Console.WriteLine();

           }

       }

    }

