using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace Fileio
{
    class streamio
    {
        static void Main(string[] args)
        {
            string path = "h:\\program\\temp.txt";
            using (FileStream f = new FileStream(path, FileMode.OpenOrCreate))
            {
               using( StreamWriter fw = new StreamWriter(f))
               
                {
                    fw.WriteLine("statment 1");
                    fw.WriteLine("statment 2");
                    fw.WriteLine("statement 3");
                   // Write Array data in File (int and string )
                   /* int[] num = { 11, 12, 13, 14, 15 };
                    foreach (var item in num)
                    {
                        fw.Write(item + " ");
                    }
                    Console.WriteLine("write data successfully");
                
                    
                    string[] name = { "hiya", "hiren", "patel" };
                    foreach (var item in name)
                    {
                        fw.Write(item + " ");
                    }
                    
                    

                    Console.WriteLine("file write successfully");*/
                }
            }
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {   //read one line
                      /*  string line = sr.ReadLine();
                        Console.WriteLine(line); */

                       /*read All line
                        string line="";
                        while((line=sr.ReadLine())!=null)
                        {
                            Console.WriteLine(line);

                        }*/

                        /* one by one character get
                        string line="";
                        while ((line=sr.ReadLine()) != null)
                        {
                            foreach (var item in line)
                            {
                                Console.WriteLine(item);
                            }
                        }*/
                        // Read character by character and store in array
                        /*string[] names = new string[10];
                        for (int i = 0; i < names.Length; i++)
                        {
                            names[i] = sr.ReadLine();
                        }
                        foreach (var item in names)
                        {
                            Console.WriteLine(item);
                        }*/

                        // Read upto end
                        //string data = sr.ReadToEnd();
                        //Console.WriteLine(data);
                        // use peek () method
                        /*if (sr.Peek() > 0)
                        {
                            Console.WriteLine(true);
                        }
                        else
                        {
                            Console.WriteLine(false);
                        }*/
                       
                    }
                }
        }
    }
    