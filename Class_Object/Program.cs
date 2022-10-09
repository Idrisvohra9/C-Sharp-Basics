using System;

namespace Class_Object
{
    // This is a class Calculator That we will use to learn the attributes and methods of the classes.
    class Calculator
    {
        // We need to use the access modifier keyword "public" to access the attributes and methods of a class via making an object. By default every field, property or a method of a class is set to the private access modifier.

        // This is a field in the class or an attribute:
        public double pi = 3.14;

        public double Add(double x, double y)
        {
            return x + y;
        }

        public double Substract(double x, double y)
        {
            return x - y;
        }

        public double Multiply(double x, double y)
        {
            return x * y;
        }

        public double Divide(double x, double y)
        {
            return x / y;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // making the object of class calculator.
            Calculator cal = new Calculator();
            Console.WriteLine(cal.pi);
            Console.WriteLine(cal.Add(2,10));
        }
    }
}
