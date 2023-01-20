using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class A
    {
        public A(string msg)
        {
            Console.WriteLine(msg);
        }
    }
    class B:A
    {
        public B():base("parent")
        {
            Console.WriteLine("this is derived class");
        }

    }
    class CodeFIle1
    {
        static void Main(string[] args)
        {
            B b1 = new B();
            Console.ReadKey();
        }
    }
}
