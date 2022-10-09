using System;

namespace Properties
{
    // This is a class Person That stores the property, name of a person.
    class Person
    {
        // The reason that we used the private access modifier is that we are just using it to assign the value to the property.
        private string name;
        // This is how a property is declared (This is a property that supports both read and write method):
        public string P_name
        {
            get
            {
                return name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("The name is empty.");
                }
                // value is a parameter for setting the value of the property.
                name = value;
            }
        }
        // Such that we can also make property that is readonly:

    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creating An object for class Person:
            Person p1 = new Person();

            p1.P_name = "Jack";// Set method will be activated
            Console.WriteLine(p1.P_name);// Get method will be activated

            //if the string is null or empty:
            p1.P_name = "";
            // Output: The name is empty.
        }
    }
}
