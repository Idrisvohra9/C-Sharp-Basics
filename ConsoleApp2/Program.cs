using System;
using System.Diagnostics;

namespace Reflection
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Constructor, AllowMultiple = true)]
    class Customer:System.Attribute
    {
        public int id { get; set; }
        public string name { get; set; }
        public Customer(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        
        public Customer()
        {

        }
        [Obsolete("Fuck off",true)]
        public void PrintId()
        {

            Console.WriteLine("Id : " + id);
        }
        [Conditional("DEBUGE")]
        public void PrintName()
        {

            Console.WriteLine("Name : " + name);
        }

    }
    class GetTypeDemo
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer();
            // Types methods:

            Type t = typeof(Customer);
            Console.WriteLine(t);
            Console.WriteLine("Name: " + t.Name);
            Console.WriteLine();

            Console.WriteLine("Namespace: " + t.Namespace);
            Console.WriteLine();

            Console.WriteLine("Attributes: " + t.Attributes);
            Console.WriteLine();

            Console.WriteLine("Methods: ");

            for (int i = 0; i < t.GetMethods().Length; i++)
            {
                Console.WriteLine(t.GetMethods()[i]);
                //Console.WriteLine("Parameters: ");
                //for (int i = 0; i < t..GetParameters().Length; i++); i++)
                //{

                //}
            }

            Console.WriteLine();
            Console.WriteLine("Properties: ");

            for (int i = 0; i < t.GetProperties().Length; i++)
            {
                Console.WriteLine(t.GetProperties()[i]);
            }
            Console.WriteLine();

            Console.WriteLine("Constructors: ");

            for (int i = 0; i < t.GetConstructors().Length; i++)
            {
                Console.WriteLine(t.GetConstructors()[i]);
            }

            Console.WriteLine();
            Console.WriteLine("Module:" + t.Module);
            Console.ReadKey();
        }
    }
}