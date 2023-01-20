using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace classobject
{
    class method
    {
        public void byvalue(int x, int y)
        {
            Console.WriteLine("byvalue"+(x + y));
        }
        public int byref(ref int x, ref int y)
        {
            return (x + y);
            x++;
        }
        public int byout(out int x, out int y)
        {
            x = 10; y = 20;
            return (x + y);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            method m1 = new method();
            int a, b,c,d;
             a =Convert.ToInt16(Console.ReadLine());
            b = Convert.ToInt16(Console.ReadLine());
            m1.byvalue(a, b);
            int add=m1.byref(ref a, ref b);
            Console.WriteLine("byref add=" + add);
            int addout=m1.byout(out c,out d);
            Console.WriteLine("by out add="+addout);

            Console.ReadKey();
        }
    }
}
