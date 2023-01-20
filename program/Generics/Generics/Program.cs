using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generics
{
    class example
    {
        public void checktype<T>(T a)
        {
            Console.WriteLine(typeof(T));
        }
        public bool check<t>(t a, t b)
        {
            bool c = a.Equals(b);
                return(c);
        }
        public void showAarry<D>(D[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            example e1 = new example();
            int[] num = new int[3];
            num[0] = 10;
            num[1] = 20;
            num[2] = 30;
            double[] num2 = { 2.5, 4.5 };
            string[] s1 = { "hi", "hello", "how" };
            e1.showAarry(num);
            e1.showAarry(s1);
            e1.showAarry(num2);
            Console.WriteLine(e1.check(10,10));
            e1.checktype("hello");
            Console.ReadLine();

        }
    }
}
