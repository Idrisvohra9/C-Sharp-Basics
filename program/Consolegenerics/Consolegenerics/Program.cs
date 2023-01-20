using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Consolegenerics
{
    class temp
    {
        public void showarray<T>(T[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        public void check<T>(object a, object b)
        {
            bool c1 = a.Equals(b);
            Console.WriteLine(c1);
            Console.WriteLine(typeof(T));
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            temp t1 = new temp();
            int[] age = new int[3];
            age[0] = 21;
            age[1] = 22;
            age[2] = 23;
            string []names = { "hi", "hello" };
            double[] p1 = new double[3];
            p1[0] = 2.5;
            p1[1] = 3.5;
            p1[2] = 4.5;
            t1.showarray(p1);
            t1.showarray(names);
            t1.showarray(age);
            t1.check(12.5, 12);
            t1.check('A','B');
            Console.ReadKey();

        }
    }
}
