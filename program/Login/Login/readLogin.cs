using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Login
{
    class readLogin // read uname password and check 
    {

        static void Main(string[] args)
        {
            string username, password,username1, password1 = string.Empty;
            Console.WriteLine("Enter a username");
            username = Console.ReadLine();
            Console.WriteLine("Enter a password");
            password = Console.ReadLine();
            using(StreamReader sr=new StreamReader(File.Open("H:\\login.txt",FileMode.Open)))
            {
               username1=sr.ReadLine();
                password1=sr.ReadLine();
            }
            if (username == username1 && password == password1)
            {
                Console.WriteLine("Login sucessfully");
            }
            else
            {
                Console.WriteLine("Incorect");
            }
            Console.ReadKey();
        }
    }
}