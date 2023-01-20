using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
namespace Arraycollection
{
    class Sortedlistdemo
    {
        static void Main(string[] args)
        {
            SortedList<string,string> sl = new SortedList<string,string>();
            sl.Add("A", "Krinal");
            sl.Add("B", "Riddhi");
            sl.Add("C", "deep");
            foreach (KeyValuePair<string,string> item in sl)
            {
                Console.WriteLine(item.Key+" : "+item.Value);
            }
            Console.WriteLine("-------------------");
            SortedList sl1 = new SortedList();
            sl1.Add("Abc", "Krinal");
            sl1.Add("pqr", "Riddhi");
            sl1.Add("bqr", "deep");
            foreach (DictionaryEntry item in sl1)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }
            Console.WriteLine();
            sl1.RemoveAt(1);
            sl1.Remove("pqr");
            Console.WriteLine("after remove method");
            Console.WriteLine();
            foreach (DictionaryEntry item in sl1)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }
           
            //SortedList<string, string> sl = new SortedList<string, string>();
            //sl.Add("7", "abc");
            //sl.Add("2", "pqr");
            //sl.Add("3", "xyz");
            //sl.Add("4", "cde");
            //Console.WriteLine(""+sl["7"]);
            //foreach (var item in sl.Keys)
            //{
            //    Console.WriteLine(item);
            //}

            //foreach (KeyValuePair<string,string> item in sl)
            //{
            //    Console.WriteLine(item.Key+""+item.Value);
            //}
            //Console.WriteLine(sl.ContainsKey("4"));
           
       
            //foreach (KeyValuePair<string, string> item in sl)
            //{
            //    Console.WriteLine(item.Key + "" + item.Value);
            //}
            //SortedList s1 = new SortedList();
            //s1.Add("7", "abc");
            //s1.Add("2", "pqr");
            //s1.Add("3", "xyz");
            //s1.Add("4", "cde");
            //s1.RemoveAt(1);
            
            //s1.Remove("1");
            
            //Console.WriteLine("-----------------------");
            //foreach (DictionaryEntry item in s1)
            //{
            //    Console.WriteLine(item.Key+" = "+item.Value);
            //}
            //Console.WriteLine(s1.Equals(s1));
            //Console.WriteLine(s1.IndexOfKey("7")) ;
           
            Console.ReadKey();
        }
    }
}