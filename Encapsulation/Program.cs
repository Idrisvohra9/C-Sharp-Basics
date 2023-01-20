using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Bank
    {
        private int bal;
        public int Get_bal()
        {
            return bal;
        }
        public void Set_bal(int b)
        {
            this.bal = b;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank b = new Bank();
            b.Set_bal(500);
            Console.WriteLine(b.Get_bal());
        }
    }
}
