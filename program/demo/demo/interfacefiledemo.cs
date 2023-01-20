using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
interface IFile
{
    void ReadFile();
    void WriteFile(string text);
}
class FileInfo : IFile
{
    public void ReadFile()
    {
        Console.WriteLine("Reading File");
    }
    public void WriteFile(string text)
    {
        Console.WriteLine("Writing to file");
    }
}
 class interfacefiledemo
{
    public static void Main()
    {
        IFile file1 = new FileInfo();
        FileInfo file2 = new FileInfo();

        file1.ReadFile();
        file1.WriteFile("content1");

        file2.ReadFile();
        file2.WriteFile("content2");
    }
}