using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generics
{
    class gc<T>
    {
        T box;
        public T p_box {
            get
            {
                return (box);
            }
            set
            {
                box = value;
            }
        }
        //public gc(T b)
        //{
        //    box = b;
        //}
        //public T getbox()
        //{
        // return (box);
        //}
        //public void print()
        // {
        //     Console.WriteLine(box);
        // }
       
    }
        
    
    class genericclass
    {
        static void Main(string[] args)
        {
            gc<int> e1 = new gc<int>();
            gc<string> e2 = new gc<string>();
            e1.p_box = 20;
            e2.p_box = "mobile";
            Console.WriteLine(e1.p_box);
            Console.WriteLine(e2.p_box);
         
         //   e1.print();
            Console.ReadLine();

        }
    }
}