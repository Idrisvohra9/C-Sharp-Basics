using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelu13demo
{
    class Address
    {
      public  int hno;
      public string colony;
      public string city;
        public Address(int x,string p,string q)
        {
            hno = x;
            colony = p;
            city = q;
        }
    }
    class person
    {
       
        string name;
        Address ap;
        public void setaddress(Address p)
        {
            ap = p;
            Console.WriteLine(ap.hno);
            Console.WriteLine(ap.colony);
            Console.WriteLine(ap.city);



        }



        //Address a1;
        //public void setAddress(Address p)
        //{
        //    a1 = p;
        //    Console.WriteLine(a1.hno);
        //    Console.WriteLine(a1.colony);
        //    Console.WriteLine(a1.city);

        //}

    }
    class Aggregation
    {
        static void Main(string[] args)
        {
            Address a1=new Address(2,"friends colony","Naranpura");
            Address a2 = new Address(3, "friends colony", "Naranpura");

            person ravi = new person();

            ravi.setaddress(a2);

            //person rahul = new person();
            //ravi.setAddress(a1);
            //rahul.setAddress(a1);
            Console.ReadKey();

        }
    }
}