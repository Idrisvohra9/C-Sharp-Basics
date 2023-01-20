using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace classobject
{
    class st
    {
      static int count=0;
       public void add()
        {
            count++;
            Console.WriteLine(count);
        }

    }
    class staticvariable
    {
        static void Main(string[] args)
        {
            st s1 = new st();
            st s2 = new st();
            s1.add();
            s2.add();
            Console.ReadKey();

           
        }
    }
}