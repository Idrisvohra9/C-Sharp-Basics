using System;

namespace Polymorphism
{
    // Polymormhism is a topic of inheritance that also aims on code reusability by making the methods and fields with same name in different classes. In order to do that there are certain keywords that need to be known.

    // In this following example the class Student is the parent class to Rajesh and howard, each of the class has a shared field named rollNo and a shared method named Subject().
    // keywords: 
    // Virtual - Override:
    // Virtual keyword is given to the fields and methods of the base class or parent class. If that particular field or method is to be overridden by the method or field of same name as the child class.
    // Here, we are only using virtual-override keyword for the rollNo field and not for the Subject() method to compare the output of them.
    // Correction: The virtual - override keyword cannot be used on fields. However It can be used on properties.
    class Student
    {
        public int rollNo = 1;

        virtual public void Subject()
        {
            Console.WriteLine("Student has a subject.");
        }
    }

    class Rajesh:Student
    {
        public int rollNo = 15;
        override public void Subject()
        {
            Console.WriteLine("Rajesh has subject Maths.");
        }
    }

    class Howard : Student
    {
        public int rollNo = 16;
        override public void Subject()
        {
            Console.WriteLine("Howard has subject Physics.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();

            Console.WriteLine("Roll No: "+s.rollNo);
            Console.WriteLine("Subject of student: ");
            s.Subject();

            Student s2 = new Rajesh();

            Console.WriteLine("Roll No: " + s2.rollNo);
            Console.WriteLine("Subject of student: ");
            s2.Subject();

            Student s3 = new Howard();

            Console.WriteLine("Roll No: " + s3.rollNo);
            Console.WriteLine("Subject of student: ");
            s3.Subject();

            // Output:

            //Roll No: 1
            //Subject of student:
            //Student has a subject.
            //Roll No: 1
            //Subject of student:
            //Rajesh has subject Maths.
            //Roll No: 1
            //Subject of student:
            //Howard has subject Physics.

            // So we can clealy see the difference between the output of field in which virtual - override keyword is not used and in the method in which virtual - override keyword is used.

        }
    }
}
