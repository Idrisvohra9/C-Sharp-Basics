using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace demo
{
  abstract class person
    {
       public int id;
       public string name;
       public int age;
       public long p_no;
       public abstract void printdetail();
       
        
    }
    class student:person
    {
        public int rollno;
        public int fees;
        public override void printdetail()
        {
            Console.WriteLine("name " + name);
            Console.WriteLine("Age " + age);
            Console.WriteLine("p_no " + p_no);
            Console.WriteLine("r_no " + rollno);
            Console.WriteLine("fees " + fees);
        }
    }
    class teacher:person
    {
        public string qul;
        public int saalry;
       public override void printdetail()
        {
            Console.WriteLine("name " + name);
            Console.WriteLine("Age " + age);
            Console.WriteLine("p_no " + p_no);
            Console.WriteLine("qul " + qul);
            Console.WriteLine("salary " + saalry);
        }
    }
    class Abstractclass1
    {

        static void Main(string[] args)
        {
            
           teacher hiya = new teacher();
            hiya.name = "hiya";
            hiya.age = 21;
            hiya.p_no = 1234567890;
            hiya.qul = "msc_IT";
            hiya.saalry= 1000;
            hiya.printdetail();
            Console.ReadKey();


        }
    }
}