using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace classobject
{
    static class sc
    {
       static int pid;
       static string pname;
       static int price;
       public static void setdetail()
        {
            pid = 101;
            pname = "book";
            price = 120;
        }
       public static void getpdetail()
        {
            Console.WriteLine("pid=" + pid);           
            Console.WriteLine("pname=" + pname);
            Console.WriteLine("price=" + price);
        }
      public static void getdiscount()
        {
            int d_amt = price / 10;
            Console.WriteLine("total cost of product is:"+(price - d_amt));
        }
    }
    class staticclass
    {
        static void Main(string[] args)
        {
            sc.setdetail();
            sc.getpdetail();
            sc.getdiscount();
            Console.ReadKey();
        }
    }
}
