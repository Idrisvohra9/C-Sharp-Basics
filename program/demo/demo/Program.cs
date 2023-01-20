using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace demo
{
   public class A1
    {
      public virtual void show()
       {
           Console.WriteLine("this is show mehod of parent class");
       }
    }
    public class B1:A1
    {
        public override void show()
        {
           
            Console.WriteLine("this is show mehod of derived  class");
        }
    }  
    class Program
    {
        
        static void Main(string[] args)
        {
           A1 d = new B1();
           d.show();
           Console.ReadKey();
           
          
         }
    }
}
