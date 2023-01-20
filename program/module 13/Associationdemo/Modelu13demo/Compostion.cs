using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelu13demo
{
    class option
    {
        string smt;
    }
    class question
    {
        int qno;
        option o1, o2, o3, o4;
        public question()
        {
            o1 = new option();
            o2 = new option();
            o3 = new option();
            o4 = new option();

        }
        ~question()
        {
            Console.WriteLine("destroy option of question");
        }
    }
    class Compostion
    {
        static void Main(string[] args)
        {
            question q1 = new question();
            question q2 = new question();

        }
    }
}