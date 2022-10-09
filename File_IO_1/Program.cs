using System;
using System.IO;

namespace File_IO_1
{
    class Program
    {
        // File IO means the process and a program that goes from creating a file writing into that file and reading from that file into console.
        static void Main(string[] args)
        {
            // We have to provide a path to a file first *It should be absolute.*:

            string path = @"C:\Users\abdev\source\repos\Main\File_IO_1\abc.txt";

            // To create a file with FileStream:
            FileStream f = new FileStream(path, FileMode.Create);
            // We can write into the file by making an instance of FileStream but it will only write blocks of bytes in the FileStream
            f.Close();

            // If we were to use FileStream it's a good practice to close the instance with Close method. In order to protect and reduce memory usage.

            // a message to show that the file is created.
            Console.WriteLine("File created.");

            // Alternately we can also create file with File.Create():

            //File.Create()

            // to write into that file:

            File.WriteAllText(path, "Aryan Topper!!");
            // Append into the file:

            File.AppendAllText(path, "BodyBuilder Peaky boy");

            // We can also create a instance for appending some content to a File by creating a stream Using StreamWriter as a class:
            StreamWriter insert = File.AppendText(path);

            // inserting one to 10 in a file:
            for (int i = 1; i <= 10; i++)
            {
                insert.Write(i);
                insert.WriteLine();
            }

            // Closing the instance:
            insert.Close();


            Console.WriteLine("Content:");
            // Read the content of the file and store it as a string variable content and print it:
            string content = File.ReadAllText(path);
            Console.WriteLine(content);

        }
    }
}