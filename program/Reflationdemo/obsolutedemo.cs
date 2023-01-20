
using System;

public class Myclass1
{
  // [Obsolete("is error",true)]
  [Obsolete("is error", false)]

    public void detail()
    {
        Console.WriteLine("excute");
    }
}
class obsolutedemo
{
    static void Main(string[] args)
    {
        Myclass1 c = new Myclass1();
        c.detail();
        Console.ReadKey();
    }
}