using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace constructordemo
{
    
    public class Employee
    {
        public Employee()
        {
            Console.WriteLine("Constructor Invoked");
        }
        ~Employee()
        {
            Console.WriteLine("Destructor Invoked");
        }
    }
    class CodeFile2
    {
        public static void Main(string[] args)
        {
            Employee e1 = new Employee();
            Employee e2 = new Employee();
           
        }
    }

}
  