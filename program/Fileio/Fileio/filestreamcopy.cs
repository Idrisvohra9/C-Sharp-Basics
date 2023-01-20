using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace Fileio
{
    class filestreamcopy
    {
        static void Main(string[] args)
        {
            string path = @"h:\program\sample.txt";
            string path1 = @"h:\program\sample1.txt";

            using (FileStream f = new FileStream(path, FileMode.Open, FileAccess.Read))
            using (FileStream fs = new FileStream(path1, FileMode.OpenOrCreate, FileAccess.Write))
            {
                f.CopyTo(fs);
                Console.WriteLine("File copy successfully");
            }
            

        }
    }
}