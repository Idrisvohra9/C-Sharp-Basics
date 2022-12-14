using System;

namespace Delegate_Method
{
    // The meaning of delegate is to assign a responsibility.
    // The same way delegate function refers to a function that is passed into it as a parameter that way delegate methods are the methods that take other methods as a parameter and return their return value.

    // Note: The data type of the parameter in delegate method is the data type of the parmeter in method which is to be passed to delegate method and its return type is the return type of the delegate method.

    // Note: The initialisation of delegate method is always between the namespace and the main class
    public delegate void Del(int i);// So this delegate method takes a method with one int parameter and with return type void.
    public delegate int Del2(int i, int j);// This delegate method takes a method with two int parameter and it will always return an int.
    class Program
    {

        public static void OddEven(int i)
        {
            string msg = "";
            if (i % 2 == 0)
            {
                msg = $"{i} is even.";
            }

            else
            {
                msg = $"{i} is odd.";
            }
            Console.WriteLine(msg);
        }

        public static void SignString(int i)
        {
            string msg = "";
            if (i < 0)
            {
                msg=$"{i} is negative.";
            }
            else if (i > 0)
            {
                msg = $"{i} is positive";
            }
            else
            {
                msg = $"{i} is zero";
            }
            Console.WriteLine(msg);
        }

        public static int Add(int i, int j)
        {
            return i + j;
        }

        static void Main(string[] args)
        {
            //Console.WriteLine(IntToString(234));
            // To call the delegate method we need to first make an object in which we will pass the name of method we want to delegate.
            Del d1 = new Del(OddEven);// Now it will point to OddEven().
            Del d2 = new Del(SignString);

            // To invoke it, is the same as invoking any other static method but in the method name we write the object name of delegate method and pass the value/s in the parameters we want to pass in the method.

            Console.WriteLine("Using delegate to see if the number 4 is odd or even: ");
            d1(4);
            Console.WriteLine("Using delegate to see the sign of number 9: ");
            d2(9);

            // Multicast Delegate:
            // We can also point to multiple methods that take parameters with same numbers and data types and delegate them at the same time with compound assignment i.e. +=, -=.

            // Calling both the methods at the same time:

            d1 += SignString;

            Console.WriteLine("Information of the number 10: ");
            d1(10);// ! Apparently it only works when the methods have a void return type because return statement cannot be added with other return statement.

            // Using Del2 to pass two parameters in a static method.

            // The object of delegate method can also be created like this:
            Del2 del2 = Add;
            Console.WriteLine("Adding 10 and 20: " + del2(10,20));

            // Passing Anonymous method that substracts two numbers passed to the object of delegate method:
            del2 = delegate (int i, int j) { return i - j; };

            // Points to remember:
            /// <summary>
            /// Anonymous method can be defined using the delegate keyword
            /// Anonymous method must be assigned to a delegate.
            /// Anonymous method can access outer variables or functions.
            /// Anonymous method can be passed as a parameter.
            /// Anonymous method can be used as event handlers.
            /// </summary>
                        Console.WriteLine("Substract 100 - 20: "+ del2(100,20));
            Console.Read();
        }
    }
}
