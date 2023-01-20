using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace delegatedemo
{
    class unaryopoverloading
    {
       public int num;
        public static unaryopoverloading operator -(unaryopoverloading u)
        {
            unaryopoverloading temp=new unaryopoverloading();
            temp.num=-u.num;
            return (temp);
        }

        static void Main(string[] args)
        {
            unaryopoverloading u1 = new unaryopoverloading();
            unaryopoverloading u2 = new unaryopoverloading();
            u1.num = 10;
            u1.num = 10;
            
            if(u1.Equals(u2))
            {
                Console.WriteLine("ok");
            }
            else
            {
                Console.WriteLine("Not ok");

            }
            //u1.num= 10;
            //u1.num = -u1.num;
           
            Console.ReadKey();
        }
    }
}