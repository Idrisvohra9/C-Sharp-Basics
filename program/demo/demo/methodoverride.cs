using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace demo
{
    class parent
{
        public  void print()
        {
            Console.WriteLine("parent");
        }
}
    class child :parent
    {
        public  void print()
        {
            Console.WriteLine("child");
        }
    }
    class derived : child
    {
        public new void print()
        {
            Console.WriteLine("derived");

        }
    }

    class methodoverride
    {
        public static void Main()
        {
           child c1 = new derived();
            c1.print();
            Console.ReadKey();
        }

    }

}