using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anonymousdelpass
{
    public delegate void calculation(int a);

    class Program
    {
        static void add(calculation c, int x)
        {
            x+=10;
            c.Invoke(x);

        }
        static void Main(string[] args)
        {

            Program.add( delegate(int b){b+=10;Console.WriteLine(b);},5);
            Console.ReadKey();
        }
    }
}