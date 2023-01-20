using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projectdemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Interface1 i1 = new Interface1();
            i1.Display();
            Connection cn = new Connection();
           
            string str = "insert into employee values(i1.Name,i1.Address)";
            cn.execute(str);
         
            
        }
    }
}
