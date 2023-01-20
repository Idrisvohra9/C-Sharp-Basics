using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace delegatedemo
{
    class newclass
    {
        public string str;
        public int num;
        public void show1()
        {
            Console.WriteLine("name=" + str);
           // Console.WriteLine("num" + num);
        }
        public static newclass operator -(newclass n1)
        {
            newclass temp = new newclass();
            temp.num = -n1.num;
            return (temp);


        }
        //public static newclass operator +(newclass n1, newclass n2)
        //{
        //    newclass temp = new newclass();
        //    temp.str = n1.str+" " + n2.str;
        //    return (temp);
        //  //  temp.num = n1.num + n2.num;

        //}
       
        //public static newclass operator +(newclass n1, newclass n2)
        //{
        //    newclass n3=new newclass();
        //    n3.str = n1.str+" " + n2.str;
        //    return n3;
        //}


    }
   
    class binaryopoverloading
    {

        static void Main(string[] args)
        {
            newclass s1 = new newclass();
            newclass s2 = new newclass();
            newclass s3 = new newclass();
            s1.num = 2;
            //s1.str = "hello";
            //s2.str = "how r you?";
            //s1 = s1 + s2;
           // s1.show1();
            s3 = -s1;
            Console.WriteLine(s3.num);
            //Console.WriteLine(s3.str);
           
        

            Console.ReadKey();
           // Console.WriteLine(s3.str);
        }
    }
}