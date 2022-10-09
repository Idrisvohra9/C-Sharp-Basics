using System;
using System.IO;

namespace File_IO_SwitchCase
{
    /// <summary>
    /// In this file we will do everything that file IO has to offer with the plus point of user getting to input and it will go through a switch case.
    /// </summary>
    class Program
    {
        public static void UserInputTaker(int choice)
        {
            switch (choice)
            {
                case 1:
                    Console.Write("Enter the name(extension not required!): ");

                    string f = Console.ReadLine();

                    File.Create(@"C:\Users\abdev\source\repos\Main\File_IO_SwitchCase\" + f + ".txt");

                    Console.WriteLine("New File " + f + ".txt" + " created..");
                    break;

                case 2:
                    Console.Write("Enter the name of file to Check if it exists: ");
                    string checkF = Console.ReadLine();

                    if (File.Exists(@"C:\Users\abdev\source\repos\Main\File_IO_SwitchCase\" + checkF + ".txt"))
                    {
                        Console.WriteLine("The file already exists.");
                    }
                    else
                    {
                        Console.WriteLine("File does not exist.");
                        Console.WriteLine("Do you want to create it?(y/n):");
                        char c = (char)Console.Read();
                        if (c == 'y')
                        {
                            choice = 1;
                        }
                    }

                    break;

                case 3:

                    break;

                case 4:
                    break;

                case 5:
                    break;

                case 6:
                    break;

                case 7:
                    break;

                case 8:
                    break;
            }
        }
        static void Main(string[] args)
        {
            char c;
            bool run = true;
            while (run)
            {
                Console.WriteLine(
                    "Enter the following integers to perform these actions and 'E' to exit:\n" +
                    "1. Create a new File\n" +
                    "2. See if a file already exists\n" +
                    "3. Open a File\n" +
                    "4. Write into the file\n" +
                    "5. Print The contents of the file\n" +
                    "6. Copy file's Content to new File\n" +
                    "7. Delete the file\n" +
                    "8. Replace the contents of file with another File content\n"
                    );

                c = (char)Console.Read();

                if (c.Equals('e') || c.Equals('E')) run = false;
                else
                {
                    int choice = Convert.ToInt32(c);
                    UserInputTaker(choice);
                }

            }

        }
    }
}
