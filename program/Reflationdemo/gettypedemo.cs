using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
namespace Reflationdemo
{
    public class customer
    {
     
        public int id { get; set; }
        public string name { get; set; }
        
        public customer(int id,string nm)
        {
            this.id = id;
            this.name = nm;
        }
        public customer()
        {

        }
        public void getdata(string s)
        {
        }
        public void printid()
        {
            Console.WriteLine("ID = "+id);
        }
        public void printname()
        {
            Console.WriteLine("Name = "+name+"");
        }
    }
    class gettypedemo
    {
        static void Main(string[] args)
        {



          customer c = new customer();
          Type t = typeof(customer);
       
            //or
          //Type t1 = c.GetType();
          
          //or
          //Type t = Type.GetType("Reflationdemo.customer");

          PropertyInfo[] properties = t.GetProperties();
          foreach (var p in properties)
          {
              Console.WriteLine(p);
          }
          MethodInfo[] methods = t.GetMethods();
          foreach (var item in methods)
          {
              ParameterInfo[] prm = item.GetParameters();
              foreach (var im in prm)
              {
                  Console.WriteLine("method : " + item.Name + im.ToString());
              }
              Console.WriteLine("method = "+item.Name);
          }
          ConstructorInfo[] ctor = t.GetConstructors();
          foreach (var i in ctor)
          {
              //Console.WriteLine("ctor = " + i.Name);
              Console.WriteLine("ctor = " + i.ToString());
          }
              Console.WriteLine(t);
              Console.WriteLine(t.Namespace);
              Console.WriteLine(t.Name);
              Console.WriteLine(t.FullName);
            Console.ReadKey();
        }
    }
}