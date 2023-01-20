using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Indexer
{
    class PrivateList<T>
    {
        public static int L = 0;
        public PrivateList(int l)
        {
            L = l;
            Console.WriteLine("Length of list: ",L);
        }
        public void Push(T elem)
        {
            if (!Peek())
            {
                L++;
                arr[L-1] = elem;
            }
        }

        public T[] Pop()
        {
            return arr.Skip(arr.Length-1).ToArray();
        }

        public bool Peek()
        {
            if (L == 0)
            {
                Console.WriteLine("List is empty.");
                return false;
            }
            else
            {
                Console.WriteLine("List contains elements.");
                return true;
            }
        }
        //static int i = 1;
        public T[] arr;
        resize();

        public static void resize()
        {
            if (L == 0) { arr = new T[L+1]; }
            else
            {
                Array.Resize(ref arr, L);
            }
        }
        public int Length => arr.Length;

        public T this[int index]
        {
            get => arr[index];
            set => arr[index] = value;
        }
        public override string ToString()
        {
            string result = "{ " + (String.Join(", ", arr)) + " }";
            if (result != null)
                return result;
            else return "Array is empty";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            PrivateList<int> list = new PrivateList<int>(5);
            //for (int i = 0; i < 11; i++)
            //{
            //    list.Push(i);
            //}
            list.Push(1);
            Console.WriteLine(list);
            //Stack<int> list2 = new Stack<int>();
            //list2.Push(1);
            Console.Read();
        }
    }
}
