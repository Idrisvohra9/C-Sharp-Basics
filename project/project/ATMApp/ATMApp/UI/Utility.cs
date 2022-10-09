using System;
using System.Globalization;
using System.Text;

namespace ATMApp.UI
{
    public static class Utility
    {
        private static long tranId;
        private static CultureInfo culture = new CultureInfo("en-IND");

        public static long GetTransactionId()
        {
            return ++tranId;

        }
        public static string GetSecretInput(string prompt)
        {
            bool isPrompt = true;
            string n = "";

            StringBuilder input = new StringBuilder();

            while (true)
            {
                if (isPrompt)
                    Console.WriteLine(prompt);
                isPrompt = false;
                ConsoleKeyInfo inputKey = Console.ReadKey(true);
                if (inputKey.Key == ConsoleKey.Enter)
                {
                    if (input.Length == 6)
                    {
                        break;
                    }
                    else
                    {
                        PrintMsg("\nThe Key should be of 6 digits**", false);
                        isPrompt = true;
                        input.Clear();
                        continue;
                    }
                }
                if (inputKey.Key == ConsoleKey.Backspace && input.Length > 0)
                {
                    input.Remove(input.Length - 1, 1);

                }
                else if (inputKey.Key != ConsoleKey.Backspace)
                {
                    input.Append(inputKey.KeyChar);
                    Console.Write(n + "*");
                }
            }
            return input.ToString();
        }

        /// <summary>
        /// Print a messge to the console and leave the second parameter ommited for the text color to indicate
        /// Success, false if the message indicates failure.
        /// <param name="msg"></param>
        /// <param name="success"></param>
        /// </summary>
        public static void PrintMsg(string msg, bool success = true)
        {
        
            if (success)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            Console.WriteLine(msg);
            Console.ForegroundColor = ConsoleColor.White;
            PressEnterToContinue();
        }
        public static string GetUserInput(string prompt)
        {
            Console.WriteLine($"Enter {prompt}");
            return Console.ReadLine();
        }
        public static void DoProcess(int timer = 10)
        {

            for (int i = 0; i < timer; i++)
            {
                Console.Write(".");
                System.Threading.Thread.Sleep(200);
            }
            Console.Clear();
        }
        public static void PressEnterToContinue()
        {
            Console.WriteLine("\n Press Enter To Continue \n");
            Console.ReadLine();
        }
        public static string FormatAmount(decimal amt)
        {
            return string.Format(culture, "{0:C}", amt);
        }
    }
}
