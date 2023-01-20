using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
namespace Arraycollection
{
    class commandline
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine("Arguments Values are {0}", args[i]);
            }
            Console.ReadKey();
        }
    }
}