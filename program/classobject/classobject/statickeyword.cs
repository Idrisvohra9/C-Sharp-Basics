using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace classobject
{
    static class methodstatic
    {
       static int x = 0;
        public static void byvalue(int x, int y)
        {
           
            Console.WriteLine("byvalue" + (x + y));
        }
        public static void print()
        {
            Console.WriteLine(x);
            byvalue(3, 4);
        }
    }
    class statickeyword
    {
        static void Main(string[] args)
        {
            
            methodstatic.byvalue(10, 20);
        }
    }
}
