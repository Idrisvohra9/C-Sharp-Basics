using System;
namespace demo
{
    public abstract class Employee
    {
        public string fname, lname;
        public abstract void getname();
        public abstract void print();
    }
    public class e1 : Employee
    {
        public override void getname()
        {
            fname = "hiya";
            lname = "patel";
        }
        public override void print()
        {
            Console.WriteLine("e1 class fname and lname" + fname + lname);
        }
    }
    public class e2 : Employee
    {
        public override void getname()
        {
            fname = "hiren";
            lname = "patel";
        }
        public override void print()
        {
            Console.WriteLine("e2 class fname and lname" + fname + lname);
        }
    }
    public class abstractdemo
    {
        public static void Main()
        {
            e1 es1 = new e1();
            e2 es2 = new e2();
            es1.getname();
            es2.getname();
            es1.print();
            es2.print();
            Console.ReadKey();
        }
    }
}