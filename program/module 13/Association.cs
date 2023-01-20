using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelu13demo
{

    public class car
    {

    }
    class driver
    {
        public void drive(ref car c)
        {
            Console.WriteLine("car driving");
        }
    }
class Association
    {
        static void Main(string[] args)
        {
            driver d1=new driver();
            driver d2=new driver();
            driver d3=new driver();
            car c1=new car();
            car c2 = new car();

            d1.drive(ref c1);
            d2.drive(ref c1);
            d3.drive(ref c2);
            Console.ReadKey();

        }
    }
}
