using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace databasedemo.DAL
{
    //  All Methods defination  of Program class
    public class StudentDAL
    {
        public void AddStudent(string fname, string lname, string dateofbirth)
        {
            DbConnect connect = new DbConnect();  //create DbConnect class instanse
            string query = string.Format("INSERT INTO Students(Fname,Lname,Dob) Values('{0}','{1}','{2}')", fname, lname, dateofbirth);
            connect.ExecuteNonQuery(query); // call ExecuteNonQuery Method of DBConnect class 
        }

        public DataTable GetStudents()
        {
            DbConnect connect = new DbConnect();
            string query = "SELECT Id,Fname,Lname,Dob FROM Students";
            DataTable students = connect.ExecuteAdapter(query); // query data get in table  and store in DataTable by index
            return students;
        }

        public DataTable GetStudentsById(string Id) // get data by student id and store in datatable
        {
            DbConnect connect = new DbConnect();
            string query = "SELECT Id,Fname,Lname,Dob FROM Students WHERE Id=" + Id;
            DataTable students = connect.ExecuteAdapter(query);
            return students;
        }

        public void UpdateStudent(string id, string fname, string lname, string dateofbirth)
        {
            DbConnect connect = new DbConnect();
            string query = string.Format("UPDATE Students SET Fname='{0}',Lname='{1}',Dob='{2}' WHERE Id={3}", fname, lname, dateofbirth, id);
            connect.ExecuteNonQuery(query);
        }
        public void DeleteStudent(string Id)
        {
            DbConnect connect = new DbConnect();
            string query = string.Format("DELETE FROM Students WHERE Id={0}", Id);
            connect.ExecuteNonQuery(query);
        }
    }
}
