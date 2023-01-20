using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace constructordemo
{
    class pdemo
    {
        string name;
        string location;
       public pdemo()
        {
            Console.WriteLine("hello private of pdemo");
        }
       public pdemo(string s1, string l1)
       {
           name = s1;
           location = l1;
       }
    }
    class Program
    {
       Program()
        {
            Console.WriteLine("hello private");
        }
        static void Main(string[] args)
        {
            Program p1=new Program();
            pdemo p2;
            Console.ReadKey();
        }
    }
}
