using System;

namespace Operator_Overloding
{
    class Op_overloading
    {
        public string str = "";
        public int i = 0;
        public static Op_overloading operator + (Op_overloading n1, Op_overloading n2)
        {
            Op_overloading temp = new Op_overloading();
            temp.str = n1.str + " " + n2.str;
            return temp;
        }
        public void Show()
        {
            Console.WriteLine(str);
            Console.WriteLine(i);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Op_overloading o1 = new Op_overloading();
            Op_overloading o2 = new Op_overloading();
            Op_overloading o3 = new Op_overloading();

            o1.str = "Idris";
            o2.str = " Vohra";
            o3.str = o1.str + o2.str;

            o1.i = 10;
            o2.i = 20;
            o3.i = o1.i + o2.i;

            o3.Show();

            Op_overloading o2_1 = new Op_overloading();
            Op_overloading o2_2 = new Op_overloading();
            _ = new Op_overloading();

            o2_1.str = "Milind";
            o2_2.str = "Rathod";

            Op_overloading o2_3 = o2_1 + o2_2;

            Console.WriteLine(o2_3);
        }
    }
}