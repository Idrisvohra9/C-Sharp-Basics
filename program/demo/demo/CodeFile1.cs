using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace demo
{
    interface i4
    {
        void print1();
        
        }
    interface i5
    {
        void print2();
        
    }
    interface i6:i4,i5
    {
        void print3();
          
    }
    class interdemo:i6
    {
        public void print1()
        {
            Console.WriteLine("show1");
        }
        public void print2()
        {
            Console.WriteLine("show2");
        }
        public void print3()
        {
            Console.WriteLine("show3");
            
        }
    }
    
    class CodeFIle1
    {

        static void Main(string[] args)
        {
            //interdemo i=new interdemo();
            //i.print1();
            //i.print2();
            //i.print3();
            i6 i = new interdemo();
            i.print1();
            Console.ReadKey();
        }
    }
}