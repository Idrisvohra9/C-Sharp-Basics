using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Methode
{
    class Program
    {
       static void Main(string[] args)
        {
            int i=10;
            print(i);
            Console.WriteLine("i=" + i);//call by value no change value of i
            print2(ref i);
            Console.WriteLine("i=" + i);//call by ref change value of i
            print3(out double j);
            Console.WriteLine("i=" + i);
            Console.ReadKey();
        }
       static void print(int s1)
        {
            
            Console.Write(s1);
            s1++;
        }
       static void print2(ref int j)
        {
            Console.WriteLine(j);
            j++;
        }
       static void print3(out double j)
         
       {
           Console.WriteLine(j);
           j++;
       }

    }
}