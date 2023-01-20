using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace constructordemo
{
    class User
    {
        public string name;
        public string location;
        public User(string n1, string l1)
        {
            name = n1;
            location = l1;
        }
        public User(User u1)
        {
            name = u1.name;
            location = u1.location;
        }
    }
    class copyconstructor
    {
        static void Main(string[] args)
        {
            User u1 = new User("kajal", "Ahmedabad");
            User u2 = new User(u1);
            Console.WriteLine(u1.name);
            Console.WriteLine(u1.location);
            Console.WriteLine(u2.name);
            Console.WriteLine(u2.location);
            Console.ReadKey();
        }
    }
}