using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Login
{
    class Program // write uname and password in file
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("we create new user");
            string username, password = string.Empty;
            Console.WriteLine("Enter a Username : ");
            username = Console.ReadLine();
            Console.WriteLine("Enter a password: ");
            password = Console.ReadLine();
            using(StreamWriter sw=new StreamWriter(File.Create("H:\\login.txt")))
            {
                sw.WriteLine(username);
                sw.WriteLine(password);

            }
            Console.WriteLine("doen...");
            Console.ReadKey();
        }
    }
}