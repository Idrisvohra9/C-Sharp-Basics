using System;

namespace Call_by_ref
{
    class Program
    {
        public void Countmethod(int i)
        {
            i++;
            Console.WriteLine(i);
        }
        public void Countref(ref int a)
        {
            a++;
            Console.WriteLine(a);
        }
        public void Countout(out int b, out int c)
        {
            int x1 = 10;
            int x2 = 6;
            b = x1;
            c = x2;
        }
        static void Main(string[] args)
        {
            int x = 10;
            int y = 3;
            int p, q;
            Program obj = new Program();
            obj.Countmethod(x);
            Console.WriteLine("x = " + x);// 11
            obj.Countref(ref y);
            Console.WriteLine("y = " + y);// 
            obj.Countout(out p, out q);
            Console.WriteLine("p = " + p + " and q = " + q);
            Console.ReadKey();
        }
    }
}