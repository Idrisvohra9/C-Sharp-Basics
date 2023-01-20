using System.Collections;
using System;
namespace Arraycollection
{
    class Arraylistdemo
    {
        static void Main(string[] args)
        {
            ArrayList l1 = new ArrayList(3);
            l1.Add(1);
            l1.Add("chandni");
            l1.Add("patel");
            l1.Add('F');
            l1.Insert(3, "Faculty");
            l1.Remove('F');
            l1.RemoveAt(0);
          //  System.Console.WriteLine(l1.Capacity);
            foreach (var item in l1)
            {
                Console.WriteLine(item);
            }
            //Console.WriteLine("data instreted");
            //l1.RemoveAt(0);
            //l1.Remove("patel");
            //System.Console.WriteLine(l1.Capacity);
            //Console.WriteLine("data display");
            
            //Console.WriteLine("count="+l1.Count);
            //l1.Insert(1, "female");
            
            Console.ReadKey();
        }
    }
}