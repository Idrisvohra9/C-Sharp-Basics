using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultParameter
{
    internal class Program
    {
        public static int Add(int n1, int n2 = 10)
        {
            return (n1 + n2);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Add(20,30));// This is how a method without default parameter works.
            Console.WriteLine(Add(20));// Not providing the second parameter in the method and making the use of default parameter.
            // 
        }
    }
}
