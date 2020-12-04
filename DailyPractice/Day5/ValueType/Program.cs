using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueType
{
    class Program
    {
        static void Main1(string[] args)
        {
            Display(0);
            Display1(Msg.M3);
        }
        static void Display(int t)
        {
            if (t == 0)
                Console.WriteLine("Hello World!!");
            else if (t == 1)
                Console.WriteLine("Hello India!!");

        }
        static void Display1(Msg t)
        {
            if (t == Msg.M1)
                Console.WriteLine("Hello World!!");
            else if (t == Msg.M2)
                Console.WriteLine("Hello India!!");
            else if (t == Msg.M3)
                Console.WriteLine("Hello CDACian!!");
        }
        
        static void Main()
        {
            MyPoint p;
            p.x = 100;
            p.y = 200;
            Console.WriteLine(p.x);
            Console.WriteLine(p.y);
        }
    }
    public enum Msg
    {
        M1 = 0, M2, M3
    }
    public struct MyPoint
    {
        public int x, y;
        public MyPoint(int x,int y)
        {
            this.x = x;
            this.y = y;

        }
        //structs are Value Types - stored on stack. Faster than Heap operations
        //No Inheritance allowed in structs
        //Parameterless constructor not allowed in structs
    }
}
