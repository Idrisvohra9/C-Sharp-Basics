using System;

namespace Inheritance_and_Interface
{
    // In this file we will be learning about inheritance.
    // Inheritance:
    // Accessing the methods, variables(fields) and all the types of related code from one class to another class is called inheritance.
    // The ':' colon is used to identify that the class is inherited from another class.
    // Syntax : DerivedClass : ParentClass
    // DerivedClass in here is also called child class meaning that it inherits from the parent class.

    // There are mainly 4 types of inheritance:

    // 1. Single Inheritance.
    // 2. Multi-Level Inheritance.
    // 3. Heirachical Inheritance.
    // 4. Multiple Inheritance.
    // 5. Hybrid Inheritance.
    // Example of single inheritance:

    class CarDetails
    {
        public int wheels = 4;
        public string ControlType = "Manual";
        public string carType = "SUV";
        public string Company = "BMW";
        public string color = "Green";
    }

    class Peddals : CarDetails
    {
        public void Accelator()
        {
            Console.WriteLine("The Gas Peddal is pressed.");
        }

        public void Brake()
        {
            Console.WriteLine("The Brake is pressed.");
        }

        public void Clutch()
        {
            Console.WriteLine("The Clutch is pressed.");
        }
    }

    // If one class inherits from the other the inheritance is single inheritance.

    /*Single Inheritance ends here*/

    // Example of Multilevel Inheritance:

    // So it continues the inheritance from the class CarDetails -> Peddals -> Gears

    class Gears : Peddals
    {
        public void AtGearOne()
        {
            Console.WriteLine("Speed: 5-10Km/h");
        }
        public void AtGearTwo()
        {
            Console.WriteLine("Speed: 10-30Km/h");
        }
        public void AtGearThree()
        {
            Console.WriteLine("Speed: 30-50Km/h");
        }
        public void AtGearFour()
        {
            Console.WriteLine("Speed: 50-70Km/h");
        }
        public void AtGearReverse()
        {
            Console.WriteLine("On reverse Gear.");
        }
    }

    // In Multilevel inheritance the Base class is inherited by a child class and that child also gets inherited to another class i.e. The child of the child class.

    /*The Multilevel inheritance ends here*/

    // Example of Heirachical inheritance:

    class ExtendedDescription : CarDetails
    {
        public int Seats = 5;
        public string Fuel = "Petrol";
        public int EngineCC = 2998;
    }

    //If we look at the times the CarDetails class has been inherited from i.e. more than one time. We can see the use of heirachical inheritance.

    // Therefore, If there are many derived class of a base class the inheritance is heirachical inheritance.

    /*End of heirachical inheritance*/

    // Example of Multiple inheritance:

    // This is not possible normally because the ':' colon or the keyword that represents the inheritance only supports 1 class that is the parent class. Therefore a new topic called interface comes to play.

    // interface: Another way to achieve abstraction in C#, is with interfaces.
    // An interface is a completely "abstract class", which can only contain abstract methods and properties (with empty bodies). To implement multiple interfaces, separate them with a comma (see example below).

    // Notes for interface:

    // Like abstract classes, interfaces cannot be used to create objects.
    // Interface methods do not have a body - the body is provided by the "implement" class
    // On implementation of an interface, you must override all of its methods
    // Interfaces can contain properties and methods, but not fields/variables
    // Interface members are by default abstract and public
    // An interface cannot contain a constructor (as it cannot be used to create objects)

    // Why and when do we use interfaces?
    // 1. To achieve security - hide certain details and only show the important details of an object (interface).
    // 2. C# does not support "multiple inheritance" (a class can only inherit from one base class). However, it can be achieved with interfaces, because the class can implement multiple interfaces.
    interface OtherEquipments
    {
        void Horn();
        void TouchScreenDisplay();
    }

    class Car : Gears, OtherEquipments
    {
        public void Horn()
        {
            Console.WriteLine("Tuut Tuut");
        }

        public void TouchScreenDisplay()
        {
            Console.WriteLine("Touch Screen has: Radio, Navigation, Music and reverse camera.");
        }
    }

    // Yup, You thought that inheritance is over and ther couldn't be another topic but you couldn't be more wrong haha!. There is another topic of sealed keyword.

    // ! Sealed keyword: sealed keyword is used as a prevention for other classes to inherit the class.
    // for example:

    sealed class InteriorAndExterior
    {
        public string SeatMaterials = "Leather";
        public int AC = 4;
        public int speakers = 4;
    }
    //class Car:InteriorAndExterior; // Error
    //it cannot be inherited by other classes as sealed keyword is used.
    class Program
    {
        static void Main(string[] args)
        {
            // Example of calling a method and fields from single inheritance:
            Peddals p1 = new Peddals();
            Console.WriteLine("Wheels: " + p1.wheels);

            Console.WriteLine("Car type: " + p1.carType);

            Console.WriteLine("Company: " + p1.Company);

            Console.WriteLine("Color: " + p1.color);

            p1.Accelator();
            p1.Brake();
            p1.Clutch();
            InteriorAndExterior i = new InteriorAndExterior();
            Console.WriteLine(i.AC);
            // Examples of calling methods and fields from multilevel inheritance:
            Gears g1 = new Gears();

            g1.AtGearFour();
            g1.Brake();
            g1.AtGearOne();

            // Example of calling methods and fields from Heirachical inheritance:

            ExtendedDescription ed1 = new ExtendedDescription();

            Console.WriteLine("Car Type: " + ed1.carType);

            Console.WriteLine("Engine cc: " + ed1.EngineCC);

            Console.WriteLine("Fuel: " + ed1.Fuel);

            // Example of calling the methods and fields from multiple inheritance:

            Car c1 = new Car();

            c1.Accelator();
            c1.AtGearTwo();
            c1.Brake();
            c1.AtGearReverse();
            c1.Horn();
        }
    }
}
