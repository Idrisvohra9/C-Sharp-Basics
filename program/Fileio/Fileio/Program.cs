using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace Fileio
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"h:\program\abc.txt";//@ verbatin literal
            using (FileStream f = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))//Append mode access with only write 
            {
                Console.WriteLine("file created");

                string data = "welcome to c#";
                byte[] w_data = Encoding.UTF8.GetBytes(data);
                f.Write(w_data, 0, data.Length);
                Console.WriteLine("file write successfully");

                //byte[] w_data = Encoding.UTF8.GetBytes(data);
                //f.Write(w_data, 0, data.Length);
               // Console.WriteLine("file write sucessfully");
            }
            using (FileStream f = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read))
            {

                byte[] r_data = new byte[1024];
                int byter = f.Read(r_data, 0, r_data.Length);
                Console.WriteLine(Encoding.UTF8.GetString(r_data,0,byter));
                Console.WriteLine("file rerad successfully");
                   
                

                //byte[] r_data = new byte[1024];
                //int byteread = f.Read(r_data, 0, r_data.Length);
                //Console.WriteLine(Encoding.UTF8.GetString(r_data, 0, byteread));

            }

            //f.WriteByte(65);
            //f.WriteByte(67);

            //Console.WriteLine(f.ReadByte());
            //for (int i = 65; i < 91; i++)
            //{
            //    f.WriteByte((byte)i);
            //}

            // f.Close();
            Console.ReadKey();
        }
        }
}
    
