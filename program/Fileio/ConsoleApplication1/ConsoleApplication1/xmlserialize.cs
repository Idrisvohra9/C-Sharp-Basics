using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace ConsoleApplication1
{
    class xmlserialize
    {
      
        static void Main(string[] args)
        {
            //string path = @"h:\program\abc.txt";
            //Employee e1 = new Employee(101, "hiya");
            //Type datatype=typeof(Employee);
            //XmlSerializer xs = new XmlSerializer(datatype);
            //TextWriter tx = new StreamWriter(path);
            //xs.Serialize(tx, e1);
            //Console.WriteLine("success");

           // dexmlserialize
            string path = @"h:\program\abc.txt";
            Employee e1 = new Employee();
            Type datatype = typeof(Employee);
            XmlSerializer xs = new XmlSerializer(datatype);
           TextReader Reader = new StreamReader(path);
           e1 = xs.Deserialize(Reader) as Employee;
         
          //Console.WriteLine("deserialize success");
          Console.WriteLine(e1.id);
          Console.WriteLine(e1.name);
          
            Console.ReadKey();
            }
            
        }
    }

