using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class methodoverload
    {
        static void Main(string[] args)
        {
            int a1 = add(10, 20);
            Console.WriteLine("a1=" + a1);
            int a2 = add(10, 20, 30);
            Console.WriteLine("a2=" + a2);
            double a3 = add(1.3, 2.4, 3.5, 4.6);
            Console.WriteLine("a3=" + a3);
            double a4 = add(1.3, 2.4);

            Console.WriteLine("a4=" + a4);
            Console.ReadKey();
        }
        static int add(int a, int b)  //two int type Parameters method  
        {
            return a + b;

        }
        static int add(int a, int b,int c)  //three int type Parameters with same method same as above  
        {
            return a + b+c ;

        }
        static double add(double a, double b, double c, double d)  //four float type Parameters with same method same as above two method 
        {
            return a + b + c + d;
        }
        static double add(double a, double b)  //four float type Parameters with same method same as above two method 
        {
            return a + b ;
        }   
    }
}