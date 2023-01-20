using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generics
{
    class temp<T>
    {
        T box;
        public T p_box
        {
            get
            {
                return (box);
            }
            set
            {
                box = value;
            }
        }
    }
    class genericclassproperti
    {
        static void Main(string[] args)
        {
 temp<int> t1=new temp<int>();
 t1.p_box = 12;
 Console.WriteLine(t1.p_box);
 Console.ReadKey();
        }
    }
}