using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace temp
{
    public class customer
    {

        public int id { get; set; }
        public string name { get; set; }

        public customer(int id, string nm)
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
            Console.WriteLine("ID = " + id);
        }
        public void printname()
        {
            Console.WriteLine("Name = " + name + "");
        }
    }
}
