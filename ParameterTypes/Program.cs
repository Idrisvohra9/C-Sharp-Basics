using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterTypes
{
    internal class Program
    {
        public static void Print(int i)
        {
            Console.WriteLine(i);
            i++;
        }
        public static void Print2(ref int i)
        {
            Console.WriteLine(i);
            i++;
        }
        public static void Show(out int i)
        {
            int a = 5;
            i = a;
            i *= i;
        }
        static void Main(string[] args)
        {
            var i = 10;
            var s = 20;
            Console.WriteLine("i: " + i);
            Console.WriteLine("s: " + s);
            Print(i);
            Console.WriteLine("i: " + i);
            Print2(ref i);
            Console.WriteLine("i: " + i);
            Show(out s);
            Console.WriteLine("s: " + s);

            Console.Read();
        }
    }
}
