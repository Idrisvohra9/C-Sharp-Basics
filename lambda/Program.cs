using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace lambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> l = new List<int> { 1, 2, 3, 4 };
            var square = l.Select(x => x * x);
            var i = 0;
            
            foreach (var item in square)
            {
                Console.WriteLine(item + " ");
            }

            foreach (var item in l)
            {
                i += item;
            }
            Console.WriteLine("Sum of elements: "+i);
            Console.Read();
        }
    }
}
