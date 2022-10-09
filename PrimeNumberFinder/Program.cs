using System;

namespace PrimeNumberFinder
{
    class Program
    {
        public static void PrimeFinder(int i)
        {
            int flag = 0;
            if (i > 1)
            {
                for (var n = i - 1; n > 1; n--)
                {
                    if (i % n == 0)
                    {
                        flag = 1;
                        break;
                    }
                }
            }
            else
            {
                flag = 1;
            }
            if (flag == 1)
            {
                Console.WriteLine($"{i} is a composite number.");
            }
            else
            {
                Console.WriteLine($"{i} is a prime number.");
            }
        }
        static void Main(string[] args)
        {
            PrimeFinder(37);
        }
    }
}
