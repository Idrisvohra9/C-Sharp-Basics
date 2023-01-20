using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
namespace Arraycollection
{
    class Sortedlistcopytomethod
    {
        static void Main(string[] args)
        {
            SortedList list = new SortedList();

            //Add elements to SortedList 
            list.Add(101, "India    ");
            list.Add(105, "America  ");
            list.Add(102, "Austrelia");
            list.Add(103, "Africa   ");
            list.Add(104, "Canada   ");
            //Console.WriteLine("--"+list[101]);
            Console.WriteLine("SortedList Values:");
            foreach (string value in list.Values)
            {
                Console.WriteLine("\t" + value);
            }

            //
            DictionaryEntry[] arr = new DictionaryEntry[list.Count];

            //Here we copy sorted list elements to specified index of array
            //list.CopyTo(arr, 0);
            list.CopyTo(arr, 0);
            //Now we print array elements

            Console.WriteLine("Array Values:");
            for (int index = 0; index < arr.Length; index++)
            {
                Console.WriteLine("\t" + arr[index].Value);
            }
            Console.ReadKey();
        }

    }
}