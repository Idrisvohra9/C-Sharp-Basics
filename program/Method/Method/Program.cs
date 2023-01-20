using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
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
        static void Show(out int val) // Out parameter  
        {
            int square = 5;
            val = square;
            val *= val; // Manipulating value  
        }  

        static void Main(string[] args)
        {
            int i = 10;
            int val = 50;
            print(i);
            Console.WriteLine("i=" + i);	//call by value no change value of i
            print2(ref i);
            Console.WriteLine("i=" + i);	//call by ref change value of I
            Show(out val); // Passing out argument  	/ /call by Outchange value of  val
            Console.WriteLine("Value after recieving the out variable " + val);
            Console.ReadKey();
        }
    }
}
