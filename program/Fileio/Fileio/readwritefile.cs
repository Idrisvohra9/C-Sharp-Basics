using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace Fileio
{
    class readwritefile
    {
        static void Main(string[] args)
        {
            string path =@"h:\temp.txt";
            FileStream fs1 = new FileStream(path, FileMode.Create);
            fs1.Close();

            FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
            fs.WriteByte(65);
            fs.WriteByte(66);
            fs.WriteByte(66);
            
            Console.WriteLine("file created sucessfully");
            Console.WriteLine(fs.ReadByte());
            fs.Close();
            //FileStream fs2 = new FileStream(path, FileMode.Append);
            //fs2.WriteByte(56);
            //fs2.Close();
            FileStream fr = new FileStream(path, FileMode.OpenOrCreate,FileAccess.Read);
            int i = 0;
            while ((i = fr.ReadByte()) != -1)
            {
                Console.WriteLine((char)i);
            }
            fr.Close();

            Console.ReadKey();
        }
    }
}