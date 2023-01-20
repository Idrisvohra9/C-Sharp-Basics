using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Methodeoverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            int a1, a2;
            float a3;
            a1=add(10, 20);
            a2=add(10, 20, 30);
           // a3=add(2.3,1.3,2.0,4.5);
            Console.WriteLine("a+b"+a1);
            Console.WriteLine("a+b+c" + a2);
          //  Console.WriteLine("a+b+c(float value" + a3);



        }
        static int add(int a, int b)
        {
            return (a + b);

        }
        static int add(int a, int b, int c)
        {
            return (a + b + c);
        }
      /*  static double add(float a,float b,float c , float d)
         {
                return (a + b + c+ d);
        
        }*/
       
    }
     
       
}
