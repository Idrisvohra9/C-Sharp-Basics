using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace delegatedemo
{
    //public delegate<>double Addnumber<>(double d, int x, int y);
    //public delegate void msg(string str);
    //public delegate bool mail(string m);
    class genericdelegatedemo
    {
        public static double Addnum(double x, int y, int z)
        {
            return (x + y + z);
        }
        public static void message(string strmsg)
        {
            Console.WriteLine(strmsg);
        }
        public static bool checkmail(string mail)
        {
            if (mail.ToLower().Equals("chandni@gmail.com"))
            {
                return (true);
            }
            else
            {
                return (false);
            }
        }
        

        static void Main(string[] args)
        {
        //step 2

            Func<double,int,int,double> num = Addnum;
           Action<string> m1 = message;
           Predicate<string> ismail = checkmail;
           //Func<string, bool> ismail = checkmail;

            //stepb 3
          double result=  num.Invoke(11.2, 10, 20);
          Console.WriteLine(result);
            m1.Invoke("welcome to c# programme");
          bool chk=  ismail.Invoke("chandni.patel80@gmail.com");
          Console.WriteLine(chk);
          Console.ReadKey();




          //  // Addnumber<double> num<double,int,int> = new Addnumber<double,int,int>(Addnum);
         //   //msg strmsg = new msg(message);
         //   //mail chkmail = new mail(checkmail);
         //   Func<double, int, int,double> num = Addnum;
         //   Action<string> print = message;
         //   Predicate<string> mail = checkmail;


         //   //step 3
         // double result = num.Invoke(10.1, 10, 21);
         // Console.WriteLine(result);
         //   print.Invoke("welcome");
         //bool Isresult =  mail.Invoke("chandni@gmail.com");
         //Console.WriteLine(Isresult);
            Console.ReadKey();
        }
    }
}
