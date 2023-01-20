using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fileio
{ [Serializable]
   public  class Employee
    {
        public int id;
        public string name;
        public Employee(int id,string name)
        {
            this.id=id;
            this.name=name;
                
        }

        
    }
}
