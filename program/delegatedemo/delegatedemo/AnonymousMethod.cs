using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnonymousMethod
{
    public delegate int calculation(int a);

    class Program
    {
        //static void add(int x)
        //{
        //    x+=10;
        //    Console.WriteLine(x);

        //}
     
        static void Main(string[] args)
        {
            calculation del = delegate(int x)
                {
                    x += 10;
                    //Console.WriteLine(x);
                    return (x);
                };
            Console.WriteLine(del(5)); 
           

            Console.ReadKey();
        }
    }
}