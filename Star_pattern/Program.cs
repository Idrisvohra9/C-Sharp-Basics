using System;

namespace Star_patterns
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < 6; i++)
            {
                for (int k = 6 - i; k > 0; k--)
                {
                    Console.Write(" ");
                }
                
                for (int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
}