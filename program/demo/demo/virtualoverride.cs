using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace demo
{
    class A
    {
        public virtual void show()  //virtual method
        {
            Console.WriteLine("Hello: Base Class!");
        }
    }
    class B : A
    {
        public override void show() //overrride method
        {
            Console.WriteLine("Hello: Derived Class!");
        }
    }
    class C : B
    {
        public override void show() //override method
        {
            Console.WriteLine("Am Here!");
        }
    }
    class virtualoverride
    {
        public static void Main()
        {
            /*A a1 = new A();
            a1.show();*/
            /* B b1 = new B();
             b1.show();
             C c1 = new C();
             c1.show();*/
            // A a2 = new B();
            //a2.show();
            /*A a3 = new C();
             a3.show();*/
            B b3 = new C();
            b3.show();
            Console.ReadLine();
        }
    }
}