using System;

namespace FactoialFinder
{
    class Program
    {
        public static void FactorialFinder(int i)
        {
            int f=1;
            for (var n = 1; n <= i; n++)
            {
                f *= n;
            }
            Console.WriteLine($"The factorial of {i} is {f}.");
        }
        static void Main(string[] args)
        {
            FactorialFinder(9);
        }
    }
}
