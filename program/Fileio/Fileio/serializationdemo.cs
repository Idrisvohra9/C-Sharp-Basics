using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace Fileio
{
    class serializationdemo
    {
        static void Main(string[] args)
        {
            string path = @"h:\program\sample.txt";
            
            FileStream f = new FileStream(path, FileMode.OpenOrCreate);
            Employee e = new Employee(101, "jinal");
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(f, e);
            f.Close();
            Console.WriteLine("File created successfully ->"+path);
            Console.ReadKey();
        }
    }
}