using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace statmentif
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            /*if (i == 10)
            {
                Console.WriteLine("i is 10");
            }
            else if (i == 15)
            {
                Console.WriteLine("i is 15");
            }
            else if (i == 20)
            {
                Console.WriteLine("i is 20");
            }
            else
            {
                Console.WriteLine("i is not present");
            }*/
            x=Convert.ToInt16(Console.ReadLine());   
            switch (x)
            {
                case 1:
                    Console.WriteLine("Choice is 1");
                    break;
                case 2:
                    Console.WriteLine("Choice is 2");
                    break;
                case 3:
                    Console.WriteLine("Choice is 3");
                    break;
                default:
                    Console.WriteLine("Choice other than 1, 2 and 3");
                    break;
            }
            int k = 10, m = 20;
            Console.WriteLine("k={0}m={1}", k, m);
            Console.ReadKey();
        }
    }
}
