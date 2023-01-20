using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
namespace Arraycollection
{
    class stackdemo
    {
        static void Main(string[] args)
        {
            Stack st = new Stack();
            st.Push("c LANG");
            st.Push("HTML");
            st.Push("core java");
            st.Push("c#");
            st.Push("oracle");
            st.Pop();
            st.Pop();
            st.Pop();
            st.Push("Linux");
            st.Push("VB");
            st.Clear();
            Console.WriteLine("after clear");
            foreach (var item in st)
            {
                Console.WriteLine(item);
            }
            //Console.WriteLine(st.Peek());
            //st.Pop();
            //Console.WriteLine("pop method"+st.Pop());
            //Console.WriteLine(st.Peek());
            //Console.WriteLine(st.Contains("core java")) ;
            //Console.WriteLine();
            //Console.WriteLine();
            //st.Clear();
            //Console.WriteLine("after apply pop methos");
            //Console.WriteLine();

            //foreach (var item in st)
            //{
            //    Console.WriteLine(item);
            //}
            Console.ReadLine();
        }
    }
}