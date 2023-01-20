using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1;
namespace ConsoleApplication1
{
    public class A
    {
        protected int id;
        public void getid()
        {
            id = 10;
        }
    }
    public class B : A
    {
       

    }
    class CodeFile1
    {
        static void Main(string[] args)
        {
            B a1 = new B();
            a1.getid();
            Console.ReadKey();
        }
    }
}
