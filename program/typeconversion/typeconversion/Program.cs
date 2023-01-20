using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace typeconversion
{
    class Program
    {
            static void Main(string[] args)
            {
               /* int i = 10, j;
                double f1 = 12.5;
                // i = f1;  Error
                i = (int)f1;//Explicit type 
                Console.WriteLine(i);
                f1 = i;//Implicit type
                Console.WriteLine(f1);*/
                int n1, n2;
                n1 = Convert.ToInt16(Console.ReadLine());   // convert to string no to int
                n2 = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine(n1.ToString());   //Convert int number to disply string datatype
            }
    }
}