using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            for (i = 0; i <= 4; i++)
            {
                if (i == 3)
                {
                    continue;
                }
                Console.WriteLine(i);

            }
            Console.ReadKey();
        }
    }
}
