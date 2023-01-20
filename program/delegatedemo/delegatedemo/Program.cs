using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace delegatedemo
{
    public delegate void calculation(int a,int b);
    public delegate int cal(int a,int b);
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
        static int Mul(int x, int y)
        {
          //  Console.WriteLine("Multiplication of Number=" + (x * y));
            return (x * y);
        }
        static void Main(string[] args)
        {
            calculation c1 = new calculation(Program.add);
           // c1 = Program.add;
            c1.Invoke(2, 3);
            calculation c2 = new calculation(Program.sub);
            c2.Invoke(5, 2);
          
            //c1.Invoke(4,3);
            //c1(3, 1);
            //cal c2 = new cal(Program.Mul);

            //Console.WriteLine("Mul="+c2(2, 3)) ;


            Console.ReadKey();

        }
    }
}
