using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
namespace Reflationdemo
{
    class Defaultdemo
    {
        public static int  Add(int x=6, int y=6, int z=1)
        {
            return (x + y + z);
        }
        //public static int Add(int x=10, int y)
        //{
        //    return (x + y);
        //}
        static void Main(string[] args)
        {
          int result= Defaultdemo.Add(10,20,30);
          Console.WriteLine(result);

         // Console.WriteLine(Defaultdemo.Add(12));
          Console.ReadKey();
        }
    }
}