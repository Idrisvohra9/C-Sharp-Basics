using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
namespace Arraycollection
{
    class Hashtabledemo
    {
        static void Main(string[] args)
        {
            Hashtable ht=new  Hashtable();
            ht.Add("id",101);
           ht.Add("name","parth");
            ht.Add("salary",25000.00);
            ht.Add("designation","Manager");

            ht.Add("IsMarried",false);
            //Console.WriteLine(ht.Contains("id") );
            int cnt = ht.Count;
            Console.WriteLine(cnt);
            Console.WriteLine("id".GetHashCode());
            //Console.WriteLine(ht.Contains("PARTH"));

            Console.WriteLine();

            foreach (DictionaryEntry val in ht)
            {
                Console.Write(val.Key+" = ");
                Console.WriteLine(val.Value);
            }
           // Console.WriteLine("----Display keys and value----");

           // foreach (DictionaryEntry item in ht)
           // {
           //     Console.Write(item.Key+" = ");
           //     Console.WriteLine(item.Value);
 
           // }
           // Console.WriteLine("----Display Only keys----");
           // foreach (object item in ht.Keys)
           // {
           //     Console.WriteLine(item);
           // }
           // Console.WriteLine("----Display Only values----");
           // foreach (object item in ht.Values)
           // {
           //     Console.WriteLine(item);
           // }
           // ht.Remove("parth");
           // Console.WriteLine("----Remove after delete----");
            
           // bool ch = ht.ContainsValue("Manager");
           // int hc = "ID".GetHashCode();
           //Console.WriteLine(hc);

           //ht.Clear();
           // foreach (DictionaryEntry item in ht)
           // {
           //     Console.Write(item.Key + " = ");
           //     Console.WriteLine(item.Value);

           // }
            ////Console.WriteLine(ht["designation"]);
            ////not dispay im order 
            //foreach (object key in ht.Keys)
            //{
            //    //Console.WriteLine( key);
            //    Console.WriteLine(key +"="+ht[key]);
            //}
            //foreach (object value in ht.Values)
            //{
            //    Console.WriteLine(value);
            //}
            //ht.Remove("salary");
            //Console.WriteLine("----------------");
            //foreach (object key in ht.Keys)
            //{
            //   // Console.WriteLine(key);
            //    Console.WriteLine(key + "=" + ht[key]);
            //}
            
            //Hashtable h1 = new Hashtable()
            //{
            //    {1,10},{"name","channi"},{"age",29}
            //};
            //Console.WriteLine(h1.ContainsKey("age"));
            //Console.WriteLine(h1.ContainsValue(29));
            //Console.WriteLine("age".GetHashCode());
            //Console.WriteLine(h1.Count);
            Console.ReadKey();
        }
    }
}