using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public class PrintStuff<T>
    {
        public T msg;
        public void Print(T name, T location)
        {
            Console.WriteLine("Message: " + msg);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Location: " + location);
        }
    }
    //class Add<T> where T : struct
    //{
    //    public Add(T a, T b)
    //    { 
    //        Console.WriteLine(addNum(a,b));
    //    }
    //    public int addNum(int a,int b)
    //    {
    //        return a + b;
    //    }
    //}


    internal class Program
    {
        static void Main(string[] args)
        {
            // Generic
            PrintStuff<string> Out = new PrintStuff<string>();
            Out.Print("Idris", "babra");

            PrintStuff<int> Out2 = new PrintStuff<int>();
            Out2.Print(1, 2);

            Console.Read();
        }
    }
}

// Generic methods without generic class:
//namespace Generic
//{
//    class Happy
//    {
//        public void Happiness<T>(T a, T b)
//        {
//            Console.WriteLine(a);
//            Console.WriteLine(b);
//        }
//    }
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var happy = new Happy();
//            happy.Happiness<string>("Sleep","Food");
//            Console.Read();
//        }
//    }
//}

// Generic Constraints
//namespace Generic
//{
//	// Using Constraints we can restrict the datatypes passed in the generic methods
//	// class meaning only string, Object is allowed, struct means only numeric data types are allowed.
//	class GenConstraints<T> where T : class
//	{
//		public void MyMethod(T a, T b)
//		{
//			Console.WriteLine(a);
//			Console.WriteLine(b);
//		}
//	}
//	class Program
//	{
//		static void Main(string[] args)
//		{
//			GenConstraints<String[]> gen = new GenConstraints<String[]>();
//			String[] arr = { "Hello" };
//			String[] arr2 = { "World" };
//			gen.MyMethod(arr,arr2);
//			Console.Read();
//		}
//	}
//}

// Generic class with arrays:

//namespace Generic
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            List<int> list = new List<int>();
//            list.Add(1);
//            list.Add(2);
//            list.Add(3);
//            list.Add(4);
//            list.Add(5);
//            list.Add(6);
//            list.Add(7);
//            //list.Add(8);
//            //list.Add(9);
//            Console.WriteLine("Count: " + list.Count);
//            Console.WriteLine("Capacity: " + list.Capacity);
//            foreach (var item in list)
//            {
//                Console.Write(item + " ");
//            }
//            Console.Read();
//        }
//    }
//}