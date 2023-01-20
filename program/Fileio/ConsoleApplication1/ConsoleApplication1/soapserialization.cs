using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Soap;
namespace ConsoleApplication1
{
    class soapserialization
    {
        static void Main(string[] args)
        {

            //de-serialization

            string path = @"h:\program\temp.text";


            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                SoapFormatter sf = new SoapFormatter();
                Employee e1 = (Employee)sf.Deserialize(fs);
                Console.WriteLine(e1.id);
                Console.WriteLine(e1.name);
            }
            Console.ReadKey();
        }
    }
}