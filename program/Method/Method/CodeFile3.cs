using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{

    class CodeFile3
    {

        static void add(int x, int y)
        {
            Console.WriteLine(x + y);
        }
        static void add(int x, int y, int z)
        {
            Console.WriteLine(x + y+z);
        }
        static void add(double x, double y)
        {
            Console.WriteLine(x + y);
        }
        static void Main(string[] args)
        {
            add(10, 20);
            add(10, 20, 30);
            add(2.5, 3.7);
            Console.ReadKey();
        }
    }
}