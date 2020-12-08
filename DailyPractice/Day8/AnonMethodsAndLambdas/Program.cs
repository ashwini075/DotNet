using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonMethodsAndLambdas
{
    class Program
    {
        //Action
        static void Main1(string[] args)
        {
            Action o1 = Display;
            o1();
            Action<string> o2 = Display;
            o2("sai");
            Action<string, int> o3 = Display;
            o3("ram", 4);
        }
        //Func and predicates
        static void Main2(string[] args)
        {
            Func<int, int, int> o1 = Add;
            Console.WriteLine(o1(10,20));
           
            Func<string, short, int> o2 = DoSomething;
            Console.WriteLine(o2("Aai", 50));

            Func< int,bool> o3 =IsEven;
            Console.WriteLine(o3( 50));

            Predicate<int> o4 = IsEven;
            Console.WriteLine(o4(20));

            Console.ReadLine(  );
        }

        //Annonomous functions
        static void Main()
        {
            int i = 20;
            //Action o = Display;
            //o();
           // Action o = delegate () { Console.WriteLine("Display "); };                 //works when no parameters are passed without parenthesis
            Action o1 = delegate { Console.WriteLine("Display "); ++i; };
            //o();
            o1();
            Console.WriteLine(i);
            Func<int, int, int> o3 = delegate (int a, int b)
                   {
                       return a + b;
                   };
            Console.WriteLine( o3(10,20));
            Console.ReadLine();
        }
        static void Display()
        {
            Console.WriteLine("Display ");
        }
        static void Display(String s)
        {
            Console.WriteLine("Display "+s);
        }
        static void Display(String s,int i)
        {
            Console.WriteLine("Display " + s+" "+i);
        }
        static int Add(int a,int b)
        {
            return a + b;
        }
        static int DoSomething(string a,short b)
        {
            return 1;
        }
        static bool IsEven(int a)
        {
            return a % 2 == 0;
        }
    }
}
