using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace constructordemo
{
    class overload
    {
       public string name;
       public string location;
       public overload()
        {
            name="hiya";
            location = "Ahmedabd";
        }
       public overload(string s1, string l1)
       {
           name = s1;
           location = l1;
       }
    }
    class overloadingconst
    {
        static void Main(string[] args)
        {
            overload o1 = new overload();
            overload o2 = new overload("pahal", "surat");
            Console.WriteLine(o1.name);
            Console.WriteLine(o1.location);
            Console.WriteLine(o2.name);
            Console.WriteLine(o2.location);
            Console.ReadKey();
        }
    }
}