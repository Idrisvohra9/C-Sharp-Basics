using System;

namespace Constructors
{
	// Constructors are the methods that are invoked when the object for that class is created. The name of the constructor is the name of the class.

	// It can be used to initialize certain variables or make necessary updations in the class when the object is created. It also saves time if the constructor is parameterized for the initialization of the necessary variables.

	// Here we are using overloading in second constructor to invoke it.
	class MyClass
	{
		public int number;
		// Simple Constructor:
		public MyClass()
		{
			Console.WriteLine("The first constructor is invoked.");
		}
		// Static constructor
		static MyClass()
		{
			Console.WriteLine("Static constructor invoked.");
		}

		// Copy Constructor
		public MyClass(MyClass c)
		{
			number = c.number;
			Console.WriteLine("Copy constructor invoked.");
		}

		//// Parametric constructor:
		public MyClass(int i)
		{
			number = i;
			Console.WriteLine("The second constructor (parameterize)is invoked.");
		}

		// This is a destructor:
		// It does'nt require any access modifiers and parameters and '~' (Tilde) sign is used:
		~ MyClass()
		{
			Console.WriteLine("Destructor is invoked.");
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			MyClass c = new MyClass();// first constructor should get invoked.
									  // Output: The first constructor is invoked.
			MyClass d = new MyClass();
			d.number = 10;

			MyClass c2 = new MyClass(1);// second constructor should get invoked.

			//  since we passed the value 1 to the parameter 'i'. We can get that value as we have assigned a public variable number to it.

			Console.WriteLine(c2.number);


			// Output: 1
			Console.Read();
		}
	}
}
