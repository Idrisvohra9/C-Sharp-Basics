using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Referencesdemo;
namespace referenceFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee(101, "dhara");
            Console.WriteLine(e1.id);
            Console.WriteLine(e1.name);

        }
    }
}
