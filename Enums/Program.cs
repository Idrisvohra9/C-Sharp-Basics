using System;

namespace Enums
{
    // What is enums in C#?
    // -> An enum is a special "class" that represents a group of constants (unchangeable/read-only variables).
    //To create an enum, use the enum keyword (instead of class or interface), and separate the enum items with a comma:

    //Use enums when you have values that you know aren't going to change, like month days, days, colors, deck of cards, etc.
    // Let us create some enums and experiment with them to observe their functionality in detail:
    class Program
    {
        enum Level
        {
            Easy=1,
            Medium,
            Hard
        }
        // In an emum element or item it has an underlying int value by default if not provided explicitly.
        // its like its index it starts from 0.
        // but it can be changed and its the values of the following elements will change accordingly.
        // for example now Medium is 2, Hard = 3.
        // ! The value inside the element is always integer in enums.
        enum Year
        {
            Days=365,
            Months=12,
            Hours=8760
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Level.Easy);
            //Easy
            // This will not print the value of Easy.
            Console.WriteLine(Level.Easy.GetType());// To get the type of Easy.
            //Enums.Program + Level
            // Apparently this is what the type of enum elements are in C# wtf??

            // to print the value of Easy:
            Console.WriteLine((int)Level.Easy);

            //1

            Console.WriteLine(Year.Days);
            // Days

            int days = (int)Year.Days;
            Console.WriteLine(days);
            //365

            // We can perform operations on the values of enums like this:
            Console.WriteLine(days/2);
            //182

            // Enum Methods:

            // Get the name of a specific enum member by using its value:
            Console.WriteLine("The name of enumeration whose value is 365 in Enum Year: "+Enum.GetName(typeof(Year),365));

            // GEt the names of the enum members like this:

            Console.Write("The names of enum members in year: ");
            foreach (var item in Enum.GetNames(typeof(Year)))
            {
                Console.Write(item+" ");
            }

            Console.WriteLine();
            // GEt the values of the enum members in the enum year:

            Console.Write("The values of enum members in year: ");
            foreach (var item in Enum.GetValues(typeof(Year)))
            {
                Console.Write(item + " ");
            }

        }
    }
}
