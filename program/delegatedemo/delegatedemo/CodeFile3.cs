using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace delegatedemo
{

    class Complex1
    {
        public int x;
        public int y;
       
        public void ShowXY1()
        {
            Console.WriteLine("{0} {1}", x, y);
        }
    }
    class CodeFile3
    {
        public static void Main()
        {
            Complex1 c1 = new Complex1();
            c1.x = 10;
            c1.y = 20;
            //c1.ShowXY1(); // displays 10 & 20  
            Complex1 c2 = new Complex1();
            // first way
           c2 = c1;
            //c2.ShowXY1(); // displays 10 & 20
            
            if(c1.Equals(c2))
            {
                Console.WriteLine("ok");
            }
            else
            {
                Console.WriteLine("not ok");
            }
            //second way
            Complex1 c3 = c2;
            if (c3.Equals(c2))
            {
                Console.WriteLine("ok");
            }
            else
            {
                Console.WriteLine("not ok");
            }
            Console.ReadKey();
        }
    }
}