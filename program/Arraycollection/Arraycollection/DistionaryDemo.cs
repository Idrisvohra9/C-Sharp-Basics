using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
namespace Arraycollection
{
    class DistionaryDemo
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dl = new Dictionary<string, string>();
            

            dl.Add("active","Ready to engage in physically energetic pursuits");
            dl.Add("amazing","causing grete surprize or wonder");
            dl.Add("honest","free of deceit,truthful  and sincere");
            foreach (KeyValuePair<string,string> item in dl)
            {
                Console.WriteLine(item.Key+" = "+item.Value);
            }
            Console.WriteLine();
            //Employee e2 = new Employee();
            //ArrayList l2 = new ArrayList();
            //l2.Add(2); l2.Add(20);
            //e2.showarray(l2);
            //Dictionary<string, string> Dl = new Dictionary<string, string>()
            //{
            //    {"UK", "London, Manchester, Birmingham"}, 
            //    {"USA", "Chicago, New York, Washington"}, 
            //    {"India", "Mumbai, New Delhi, Pune"} 

            //};
            //Console.WriteLine(Dl["USA"]);
            //foreach (KeyValuePair<string,string> item in Dl)
            //{
            //    Console.WriteLine(item.Key+"="+item.Value);
            //}
            //Console.WriteLine("only keys");
            //foreach (string item in Dl.Keys)
            //{
            //    Console.WriteLine(item);
            //}
           //Employee e1=new Employee()
           // {
           //     id=101,
           //     name="zara",
           //    desination="Manager",
           //    salary=20000

           //};
           // Employee e2=new Employee()
           //{
           //    id=102,
           //    name="Mahek",
           //    desination="salesManager",
           //    salary=21000

           //};
           //  Employee e3=new Employee()
           //{
           //    id=103,
           //    name="ziya",
           //    desination="PurchaseManager",
           //  salary=25000

           //};
            Employee e1 = new Employee();
            ArrayList al1 = new ArrayList();
            al1.Add(1);
            al1.Add(2);
            e1.showarray(al1);
           //Dictionary<int,Employee> dl1=new Dictionary<int,Employee>();
           //dl1.Add(e1.id, e1);
           //dl1.Add(e2.id,e2);
           //dl1.Add(e3.id,e3);
           //Console.WriteLine("Total element="+dl1.Count(emp=>emp.Value.salary>20000));
           //Console.WriteLine("Total element=" + dl1.Count(emp => emp.Value.name.StartsWith("z")));

           // if (dl1.ContainsKey(107))
           // {
           //     Console.WriteLine("key found");
           // }
           // else
           // {
           //     Console.WriteLine("key not found");
           // }
           // Employee value;
           // dl1.TryGetValue(102, out value );
           // Console.WriteLine(value);
           //// Console.WriteLine("total element="+dl1.Count(emp=>emp.Value.name.StartsWith("z")));
            Console.ReadKey();


        }
    }
}