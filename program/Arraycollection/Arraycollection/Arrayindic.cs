using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
namespace Arraycollection
{
    class Arrayindic
    {
        static void Main(string[] args)
        {
            ArrayList cno = new ArrayList();
            cno.Add(1234567890);
            cno.Add(8765456784);
            cno.Add(9876543210);
            ArrayList name = new ArrayList();
            name.Add("zara");
            name.Add("mahek");
            name.Add("mishant");
            Dictionary<ArrayList,ArrayList> dl=new Dictionary<ArrayList,ArrayList>();
            dl.Add(cno,name);
            foreach (ArrayList item in dl.Values)
            {
                for (int i = 0; i < item.Count; i++)
                {
                    Console.WriteLine(item[i]);
                }
            }
           
          //  Console.WriteLine();
	Console.ReadKey();	 
	}
        }
    }
