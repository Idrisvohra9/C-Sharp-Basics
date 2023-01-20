using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //serialize

            //string path = @"h:\program\abc.txt";
            //Employee e1 = new Employee(101, "hiya");
            //using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            //{
            //    BinaryFormatter bf = new BinaryFormatter();
            //    bf.Serialize(fs,e1);
            //    Console.WriteLine("success");
            //}

            // deserialize
            string path = @"h:\program\abc.txt";

            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                BinaryFormatter bf = new BinaryFormatter();
            Employee e1=(Employee)bf.Deserialize(fs);
            Console.WriteLine(e1.id);
            Console.WriteLine(e1.name);

            }
            Console.ReadKey();
        }
    }
}
