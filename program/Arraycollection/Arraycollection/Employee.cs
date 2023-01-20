using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Arraycollection
{
    class Employee
    {
        
        public int id { get; set; }
        public string name { get; set; }

        public string desination { get; set; }
        public int salary { get; set; }
        public void  showarray(ArrayList l)
        {
            foreach (var item in l)
            {
                Console.WriteLine(item);
            }

        }
    }
}
