using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lambdademo
{
    public delegate int calculation(int num);
   // public delegate void calculation(int num);

    public delegate int calculation1(int num1,int num2);
    class Program
    {
        static void Main(string[] args)
        {   // coding of vid calculation (int num)
            //calculation cal = (a) =>
            //{
            //    a += 5;
            //    Console.WriteLine(a);
            //};
            //cal(4);
            calculation1 c3 = (a, b) =>a + b;
            Console.WriteLine();
            calculation cal1 = (a) => a * a;
            Console.WriteLine(cal1(4));
            calculation1 cal2 =(a,b) => a * b;
            Console.WriteLine(cal2(4,2));
            Console.ReadKey();
        }
    }
}