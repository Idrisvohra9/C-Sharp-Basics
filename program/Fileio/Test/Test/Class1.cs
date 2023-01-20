using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee
{
    public class Employee
    {
        public string e_name { get; set; }
        public string e_state { get; set; }
        public int e_num { get; set; }

        public int ismale { get; set; }
        public void dispalyTime()
        {
            Console.WriteLine(DateTime.Now.ToString());
        }
        public void dispalyname(int id)
        {
            Console.WriteLine("hiya patel");
        }
    }
}
