using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApplication1
{
 [Serializable]

   public class Employee
    {
       
        public int id;
       public string name;
       public Employee()
       {

       }
        public Employee(int id1,string nm)
        {
            id = id1;
            name = nm;
        }
        public void show()
        {
            Console.WriteLine("id = "+id);
            Console.WriteLine("name = "+name);
        }
    }
}
