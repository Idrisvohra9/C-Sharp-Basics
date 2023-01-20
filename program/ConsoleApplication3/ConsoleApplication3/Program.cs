using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream f = new FileStream("C:\\Users\\hello\\Desktop\\C#\\program\\temp.txt", FileMode.OpenOrCreate);
            //creating file stream  
            for (int i = 65; i <95; i++)
            {
                f.WriteByte((byte)i);
            }
            //f.WriteByte(65);//writing byte into stream  
            f.Close();//closing stream  

        }
    }
}
