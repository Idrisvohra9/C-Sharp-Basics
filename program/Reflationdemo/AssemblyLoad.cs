using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
namespace Reflationdemo
{
    class AssemblyLoad
    {

        static void Main(string[] args)
        {

            Assembly ase = Assembly.LoadFrom(@"C:\Users\hello\Desktop\C#\program\temp\temp\bin\Debug\temp.dll");


            Type t1 = ase.GetType();
            Console.WriteLine(t1);

            //Console.WriteLine(type.Name);      
            MethodInfo[] ms = t1.GetMethods();

            foreach (MethodInfo item in ms)
            {
                Console.WriteLine(item.Name);
                ParameterInfo[] parameters = item.GetParameters();
                foreach (var prm in parameters)
                {
                    Console.WriteLine("----" + prm.Name + " " + prm.ParameterType);
                }
            }
            Console.ReadKey();

        }
    }
}

