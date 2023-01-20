using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
namespace Arraycollection
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList A1 = new ArrayList(3);
            A1.Add(1);
            A1.Add("chandni");
            A1.Add('F');
             
            //A1.Insert(2, 30);
            //A1.Remove('F');
            //A1.RemoveAt(1);
            Console.WriteLine("---DIspaly ArrayList---");
            for (int i = 0; i < A1.Count; i++)
            {
                Console.WriteLine("A1[{0}]="+A1[i],i);
            }
            
            //foreach (object item in A1)
            //{
            //    Console.WriteLine(A1[0]);
            //}
            Console.ReadLine();
        }
    }
}
