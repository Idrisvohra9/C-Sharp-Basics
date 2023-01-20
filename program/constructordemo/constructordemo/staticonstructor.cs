using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace constructordemo
{
    class staticdemo
    {
       static int x = 10;
       static staticdemo()
        {
            Console.WriteLine(x);
        }
       public staticdemo()
       {
           Console.WriteLine("i am default constructor");
       }
    }
    class staticconstructor
    {
        static void Main(string[] args)
        {
            staticdemo s1 = new staticdemo();
            staticdemo s2 = new staticdemo();
            Console.ReadKey();

        }
    }
}