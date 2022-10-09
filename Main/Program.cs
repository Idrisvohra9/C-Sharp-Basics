using System;

namespace Try_catch
{
    class Program
    {
        // The Original name of the program file should be Exception Handling but it works too ig..

        static int[] arr_i = { 1, 2, 3, 4, 5 };
        static int z = 0;
        static void Main(string[] args)
        {
            // We are going to go through 2 Exceptions 1. Going to divide the numeric elements with zero That is DivideByZero Exception and going to run the elements of the array through a loop that extends the indexes of array i.e. ArrayOutOfBounds exception and catch every exception and solve them.

            // Exception: DivideByZeroException
            try
            {
                for (int i = 0; i <= arr_i.Length; i++)
                {
                    arr_i[i] /= z;
                }
            }
            catch (DivideByZeroException d)
            {
                Console.WriteLine($"The Exception: {d.GetType()} was caught.");
                // The fix:
                // Exception: IndexOutOfRangeException
                try
                {
                    z++;// So now z is 1.
                    for (int i = 0; i <= arr_i.Length; i++) arr_i[i] /= z;
                }
                catch (IndexOutOfRangeException e)
                {
                    Console.WriteLine($"The Exception: {e.GetType()} was caught.");
                    // The fix:
                    for (int i = 0; i < arr_i.Length; i++)
                    {
                        arr_i[i] /= z;
                    }
                }
                // Then finally the array is printed out
                finally
                {
                    Console.WriteLine("The Array:");
                    Console.Write("{ ");
                    for (int i = 0; i < arr_i.Length; i++)
                    {
                        Console.Write(arr_i[i]);
                        if (i < arr_i.Length - 1) Console.Write(", ");
                    }
                    Console.Write(" }");
                }
                Console.ReadKey();
            }
        }
    }
}