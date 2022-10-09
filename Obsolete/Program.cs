using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Obsolete
{
    [AttributeUsage(AttributeTargets.All)]
    class MyClass:Attribute
    {
        private readonly string action;

        public string GetAction()
        {
            return action;
        }

        private readonly string descript;

        public string GetDescript()
        {
            return descript;
        }

        public MyClass(string Act, string Descr)
        {
            action = Act;
            descript = Descr;
        }

        public void MyMethod(object arg)
        {

            throw new NotImplementedException();
        }

        public  MyClass(string msg)
        {

        }

        [Obsolete("Generates an error.")]

        public MyClass()
        {
            Console.WriteLine("Something..");
        }

        [MyClass("This is an int","A variable")]
        public int a = 10;

        public static void GetReflection(Type classType)
        {
            Console.WriteLine("Class Name: "+classType.Name);
            Console.WriteLine("Namespace: "+classType.Namespace);
            MethodInfo[] methods = classType.GetMethods();


            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass c = new MyClass();// It will show the message..
            Console.WriteLine(c.a);
        }
    }
}
