using System;

namespace Access_modifiers
{
    // Access Modifiers are the characteristics of variables and or methods.
    // All the access modifiers are listed down below with their usage.
    class ParentClass
    {
        // private:
        int i = 10;// this is a default variable declaration but by default it has 'private' access modifier that means that the code is accessible within the same class.

        // public:
        public int j = 20;// public access modifier is used when the code is to be made accessible for all the classes in which there is object made for that class.

        protected int k = 12;// protected access modifier is used when the code is to be made accessible for the same class and the class that is inherited from that class.

        // internal access modifier: Its class and definition is on another file in this project called Internal_class.

        // static:
        public static int m = 30;// static access modifier is used when the code is to be made accessible to another class without making its object and using the class name directly with the dot operator and than the static variable's name. In order to make it accessible to other class we need to add public access modifier.
        public void PrivateVarPrinter()
        {
            Console.WriteLine(i);// print the private variable 'i'
        }
    }

    class ChildClass: ParentClass
    {
        public void ProtectedVarPrinter()
        {
            Console.WriteLine(k);// print the protected variable 'k'
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // making the object of ParentClass:
            var p = new ParentClass();

            // print the private variable 'i':
            Console.WriteLine("Private Variable 'i':");
            p.PrivateVarPrinter();


            // print the public variable 'j':
            Console.WriteLine("Public Variable 'j':");
            Console.WriteLine(p.j);
            
            // print the private variable
            // now since the protected variable can also be accessed by the class that inherits from the parent class therefore we have to make the object of the child class, In order to print the protected variable.

            ChildClass c = new ChildClass();
            Console.WriteLine("Protected Variable 'k':");
            c.ProtectedVarPrinter();

            // Printing static variable 'm':
            Console.WriteLine("Printing static variable 'm':");
            Console.WriteLine(ParentClass.m);

            // printing the internal variable 'l':
            Internal_class i = new Internal_class();
            Console.WriteLine("Printing the internal variable 'l':");
            Console.WriteLine(i.l);
            // ! there are other access modifiers such as abstract, virtual, override that is covered by our topics such as abstraction and polymorphism.
        }
    }
}
