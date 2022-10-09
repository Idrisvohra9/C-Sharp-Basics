using System;

namespace FactorsFinder
{
    class Program
    {
        public static void FactorsFinder(int i)
        {
            int[] arr= new int[100];
            int index = 0;
            for(var n = i; n >= 1; --n)
            {
                if (i % n == 0)
                {
                    arr[index] = n;
                    index++;
                }
            }
            Console.WriteLine($"The factors of {i} are: ");
            for(var j = 0; j <= index; j++)
            {
                Console.Write(arr[j]);
                if(j < index)
                {
                    Console.Write(", ");
                }
            }
        }
        static void Main(string[] args)
        {
            FactorsFinder(999);
        }
    }
}
