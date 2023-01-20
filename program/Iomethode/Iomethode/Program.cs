using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iomethode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("hello\n");
            Console.WriteLine("helloworld");
            Console.WriteLine("Enter the value");
            int i;
            string j;
            i = Console.Read();//return ANCII value of single Char
            Console.WriteLine(i);
            j = Console.ReadLine();//Return String value in String variable
            
            Console.WriteLine("j="+j+"i="+i);//+ sign to contact to string or value
            Console.ReadKey();
        }
    }
}
