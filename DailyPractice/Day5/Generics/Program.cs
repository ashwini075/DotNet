using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main()
        {
            Integerstack o = new Integerstack(4);
            o.Push(20);
            o.Push(40);
            o.Push(60);
            o.Push(80);
           
            Console.WriteLine(o.Pop());
            Console.WriteLine(o.Pop());
            Console.WriteLine(o.Pop());
            Console.WriteLine(o.Pop());
            Console.WriteLine();

            Stringstack s = new Stringstack(4);
            s.Push("hi");
            s.Push("hii");
            s.Push("hiii");
            s.Push("hiiii");
         
            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Pop());
            Console.WriteLine();
           
            MyStack<int> o1 = new MyStack<int>(4);
            o1.Push(90);
            o1.Push(20);
            o1.Push(80);
            o1.Push(40);
            Console.WriteLine(o1.Pop());
            Console.WriteLine(o1.Pop());
            Console.WriteLine(o1.Pop());
            Console.WriteLine(o1.Pop());

        }
    }
    class Integerstack
    {
        int[] arr;
        public Integerstack(int size)
        {
            arr = new int[size];

        }
        int pos = -1;
        public void Push(int i)
        {
            if (pos == (arr.Length - 1))
                throw new Exception("stack full");
            arr[++pos] = i;
        }
        public int Pop()
        {
            if (pos == -1)
                throw new Exception("stack empty");
            return arr[pos--];
        }
    }
    class Stringstack
    {
        string[] arr;
        public Stringstack(int size)
        {
            arr = new string[size];

        }
        int pos = -1;
        public void Push(string i)
        {
            if (pos == (arr.Length - 1))
                throw new Exception("stack full");
            arr[++pos] = i;
        }
        public string Pop()
        {
            if (pos == -1)
                throw new Exception("stack empty");
            return arr[pos--];
        }
    }
    class MyStack<T>
    {
        T[] arr;
        public MyStack(int size)
        {
            arr = new T[size];

        }
        int pos = -1;
        public void Push(T i)
        {
            if (pos == (arr.Length - 1))
                throw new Exception("stack full");
            arr[++pos] = i;
        }
        public T Pop()
        {
            if (pos == -1)
                throw new Exception("stack empty");
            return arr[pos--];
        }
    }

}
