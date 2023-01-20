using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Multicastdelegate
{
    public delegate void calculation(int a, int b);
    class Program
    {
        static void add(int x, int y)
        {
            Console.WriteLine("Addition of Number=" + (x + y));

        }
        static void sub(int x, int y)
        {
            Console.WriteLine("Subtration of Number=" + (x - y));
        }
        static void Mul(int x, int y)
        {
             Console.WriteLine("Multiplication of Number=" + (x * y));
           
        }
        static void Div(int x, int y)
        {
            Console.WriteLine("Division of Number=" + (x / y));

        }
        static void Main(string[] args)
        {
            calculation c3 = new calculation(Program.add);
            c3 += Program.sub; //Multicast Add sub
            c3 += Program.Mul;
            c3 += Program.Div;
            c3(5, 3);
            Console.WriteLine("=========================");
            c3 -= Program.Mul; // Subtract Mul Method
            c3.Invoke(4, 2);
            Console.ReadKey();

        }
    }
}