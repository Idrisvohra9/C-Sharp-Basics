using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using databasedemo.DAL;

namespace databasedemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to student registration program");
        START_HERE:
            Console.WriteLine("1-Add New Student");
            Console.WriteLine("2-List All Students");
            Console.WriteLine("3-Update Student");
            Console.WriteLine("4-Delete Student");
            Console.WriteLine("5-Exit");
            Console.Write("Select operation::");
            string op = Console.ReadLine();
            StudentDAL student = new StudentDAL();
            switch (op)
            {
                case "1":
                    Console.WriteLine(string.Format("You have selected {0} operaion", "add student"));
                    Console.Write("Enter First Name::");
                    string fname = Console.ReadLine();
                    Console.Write("Enter Last Name::");
                    string lname = Console.ReadLine();
                    Console.Write("Enter Date Of Birth(MM/DD/YYYY)::");
                    string dob = Console.ReadLine();
                    student.AddStudent(fname, lname, dob); // Method defination in 
                    Console.WriteLine("Student added successfully");
                    goto START_HERE;
                case "2":
                    Console.WriteLine("List all students");
                    DataTable dtStudents = student.GetStudents();
                    if (dtStudents != null && dtStudents.Rows.Count > 0)
                    {
                        Console.WriteLine(String.Format("|{0,5}|{1,20}|{2,20}|{3,20}|", "Id", "First Name", "Last Name", "Date Of Birth"));
                        foreach (DataRow dr in dtStudents.Rows)
                        {
                            Console.WriteLine(String.Format("|{0,5}|{1,20}|{2,20}|{3,20}|", dr["Id"], dr["Fname"], dr["Lname"], Convert.ToDateTime(dr["Dob"]).ToShortDateString()));
                        }
                    }
                    else
                    {
                        Console.WriteLine("No data found");
                    }
                    goto START_HERE;
                case "3":
                    Console.WriteLine("You have selected operaion to update student");
                    Console.Write("Enter student id::");
                    string id = Console.ReadLine();
                    DataTable dtStudent = student.GetStudentsById(id);
                    if (dtStudent != null && dtStudent.Rows.Count > 0)
                    {
                        DataRow dr = dtStudent.Rows[0];
                        Console.Write("Enter First Name::");
                        string newFname = Console.ReadLine();
                        newFname = String.IsNullOrEmpty(newFname) ? dr["Fname"].ToString() : newFname;
                        Console.Write("Enter Last Name::");
                        string newLname = Console.ReadLine();
                        newLname = String.IsNullOrEmpty(newLname) ? dr["Lname"].ToString() : newLname;
                        Console.Write("Enter Date Of Birth(MM/DD/YYYY)::");
                        string newDob = Console.ReadLine();
                        newDob = String.IsNullOrEmpty(newDob) ? dr["Dob"].ToString() : newDob;

                        student.UpdateStudent(id, newFname, newLname, newDob);
                        Console.WriteLine("Student updated successfully");
                    }
                    else
                    {
                        Console.WriteLine("Invalid Student Id");
                    }
                    goto START_HERE;
                case "4":
                    Console.WriteLine("You have selected operaion to Delete student");
                    Console.Write("Enter student id::");
                    string deleteId = Console.ReadLine();
                    DataTable delStudent = student.GetStudentsById(deleteId);
                    if (delStudent != null && delStudent.Rows.Count > 0)
                    {
                        Console.Write("Are you sure you want to delete this student(y/n)::");
                        string choice = Console.ReadLine();
                        if (choice.ToLower() == "y")
                        {
                            student.DeleteStudent(deleteId);
                            Console.WriteLine("Student deleted successfully");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid Student Id");
                    }
                    goto START_HERE;
                case "5":
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }

            Console.ReadKey();
        }
    }
}
