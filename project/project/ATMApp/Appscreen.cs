using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
	

public class Class1
{
	public  static Class1()
	{
		interal static void welcome()
        {
            Console.Clear();
            Console.Title = "MY ATM APP";

            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("\n \n-----------Welcome to My ATM APP----------------\n\n");
            Console.WriteLine("PLEASE INSERT YOUR ATM CARD");
            Console.WriteLine("NOTE:Actual ATM Machine will accept and validate a" +
                "phsical ATM card,read the card number and validate it.");
            Console.WriteLine("\n press Enter To continue....\n");

            Console.ReadLine();
        }

	}
}
