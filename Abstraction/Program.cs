using System;

namespace Abstraction
{
    /// <summary>
    /// Data abstraction is the process of hiding certain details and showing only essential information to the user.
    /// Abstraction can be achieved with either abstract classes or interfaces(which you will learn more about in the next chapter).
    /// The abstract keyword is used for classes and methods:
    /// 
    /// Abstract class: is a restricted class that cannot be used to create objects (to access it, it must be inherited from another class).
    /// Abstract method: can only be used in an abstract class, and it does not have a body. The body is provided by the derived class (inherited from).
    /// </summary>
    
// Abstract class
abstract class Animal
    {
        // Abstract method (does not have a body)
        public abstract void AnimalSound();
        // Regular method
        public void Sleep()
        {
            Console.WriteLine("Zzz");
        }
    }

    // Derived class (inherit from Animal)
    class Pig : Animal
    {
        public override void AnimalSound()
        {
            // The body of animalSound() is provided here
            Console.WriteLine("The pig says: wee wee");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Pig myPiggy = new Pig();
            myPiggy.AnimalSound();
            myPiggy.Sleep();

            // Output:
            //The pig says: wee wee
            //Zzz
        }
    }
}
