using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace delegatedemo
{
  
  
    public delegate int mydel(int x,int y);
    class CodeFile1
    {
       //public static void mymethod(mydel del1,int x)
       // {
       //     x += 10;//15
       //   del1(x);
       // }

       
        static void Main(string[] args)
        {

            mydel d1 = (b, x) => b += x;
    
       // Console.WriteLine(b);

            Console.WriteLine(d1.Invoke(10, 2));
            Console.ReadKey();
}
}
}
 