using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace Fileio
{
    class streamreaderunameorpsw
    {
        static void Main(string[] args)
        {
            string uname = "Admin";
            string psw = "Admin123";
            string path = @"h:\program\temp.txt";
            //using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            //{
            //    using (StreamWriter sw = new StreamWriter(fs))
            //    {
            //        sw.WriteLine(uname);
            //        sw.WriteLine(psw);
            //        Console.WriteLine("file write sucessfully");
            //    }
            //}
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                using (StreamReader sw = new StreamReader(fs))
                {
                    string line = "";
                    int index = 0;
                    string[] chk = new string[2];
                    while ((line = sw.ReadLine()) != null)
                    {
                        chk[index] = line;
                        index++;

                    }
                    foreach (var item in chk)
                    {
                        Console.WriteLine(item);
                    }
                    
                    Console.ReadKey();
                }
              
            }
        }
    }
}