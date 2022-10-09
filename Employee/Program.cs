using System;

namespace Employee
{
    abstract class Employee
    {
        public string Fname, Lname;
        public abstract void GetName();
        public abstract void Print();
    }
    class E1:Employee
    {
        public override void GetName()
        {
            Console.WriteLine("Enter First name: ");
            Fname = Console.ReadLine();
            Console.WriteLine("Enter Last name: ");
            Lname = Console.ReadLine();
        }

        public override void Print()
        {
            Console.WriteLine("First Name: " + Fname);
            Console.WriteLine("Last Name: " + Lname);
        }
        static void Main(string[] args)
        {
            E1 Emp1 = new E1();
            Emp1.GetName();
            Emp1.Print();
            Console.ReadLine();
        }
    }
}
