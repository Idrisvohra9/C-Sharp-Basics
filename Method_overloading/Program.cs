using System;

namespace Method_overloading
{
    class Program
    {
        // In this program we will learn how to overload a method.
        // Method overloading means creating many methods with a under a single method_name.
        // There are 2 ways we can do method overloading 1. If the number of parameters of the method are different 2. If the data type of parameter are different.

        // Look at the examples below to understand in detail.
        static void Add(int x, int y)
        {
            Console.WriteLine(x + y);
        }

        static void Add(int x, int y, int z)
        {
            Console.WriteLine(x + y + z);
        }

        static void Add(double x, double y)
        {
            Console.WriteLine(x + y);
        }

        static void Main(string[] args)
        {
            Add(10, 20);// This invokes the first Add method as it takes two int parameters.
            Add(10, 20, 40);// This invokes the second Add method as it takes three int parameters.
            Add(9.6, 4.67);// This invokes the third Add method as it takes two double parameters.
        }
    }
}
