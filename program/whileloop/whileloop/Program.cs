using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace whileloop
{
    class Program
    {
        static void Main(string[] args)
        {
            int ch;
            bool bk = true;
          //  while (true)
            do
            {
                //l1:
                Console.WriteLine("---Hotel Menu---");
                Console.WriteLine("1.South Indian");
                Console.WriteLine("2.Panjabi");
                Console.WriteLine("3.Exit");
                Console.WriteLine("Enter your choice");
                ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        {
                            Console.WriteLine("south indian choice");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Panjabi choice");
                            break;
                        }
                    case 3:
                        {
                            Environment.Exit(0);
                            break;
                        }
                    default:
                        {
                            bk = false;
                            Console.WriteLine("plz enter right choice");
                            //goto l1;
                            break;

                        }
                }


            } while (bk == true);




        }
    }

}