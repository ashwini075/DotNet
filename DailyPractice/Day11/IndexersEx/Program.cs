using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexersEx
{
    class Program
    {
        static void Main1(string[] args)
        {
            Class1 obj = new Class1(20);
            obj[0] = 30;
            obj[1] = 40;
            Console.WriteLine(obj[1]);
            Console.WriteLine(obj[0]);
            Console.ReadLine();
        }
       
    }
   public class Class1
    {
        int[] arr;
        int startPos;
        public Class1(int size)
        {
            arr = new int[size];
        }
        ///Indexer
     public int this[int index]
        {
            set { arr[index] = value; }
            get { return arr[index]; }
        }
    }
}

namespace IndexersEx1
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 obj = new Class1(20,50);
            obj[50] = 30;
            obj[51] = 40;
            Console.WriteLine(obj[51]);
            Console.WriteLine(obj[50]);
            Console.ReadLine();
        }

    }
    public class Class1
    {
        int[] arr;
        int startPos;
        public Class1(int size,int startPos)
        {
            arr = new int[size];
            this.startPos = startPos;
        }
        ///Indexer
        public int this[int index]
        {
            set { arr[index-startPos] = value; }
            get { return arr[index-startPos]; }
        }
    }
}
