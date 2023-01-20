using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
namespace Arraycollection
{
    class listdemo
    {
        static void Main(string[] args)
        {
            List<int> l = new List<int>();
            l.Add(2);
            l.Add(20);
            l.Add(22);
            l.Add(24);
            l.Add(25);
            List<int> l1 = new List<int>();
            l1.Add(3);
            l1.Add(30);
            l1.Add(32);
            l1.Add(34);
            l1.Add(35);
            l.AddRange(l1);
           // List<int> l = new List<int>();
           // l.Add(2);
           // l.Add(20);
           // l.Add(22);
           // l.Add(24);
           // l.Add(25);
           // List<int> newl = new List<int>();
           // newl.Add(34);
           // newl.Add(32);
           // newl.Add(33);
           // l.AddRange(newl);
           ////var cl= l.Concat(newl);
            Console.WriteLine("------------Addrange-----------");
            foreach (var item in l)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}