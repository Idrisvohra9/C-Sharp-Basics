using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace demo
{
    class person1
    {
        private string name;
      
        public int id { get;private set; }
        public person1(int i)
        {
            id = i;
        }
        public void setpro(string s)
        {
            name = s;
        }
       
        public string p_name
        {
            get
            {
                return(name);
            }
            //set
            //{
            //    if (string.IsNullOrEmpty(value))
            //    {
            //        Console.WriteLine("not empty");
            //    }
            //    else
            //    {
            //        name = value;
            //    }
            //}
        }
    }
    class CodeFIle2
    {

        static void Main(string[] args)
        {
            person1 p = new person1(1);
           // p.id = 1;
            Console.WriteLine(p.id);
            p.setpro("hello");
            
            Console.WriteLine(p.p_name);
            Console.ReadKey();
        }
    }
}