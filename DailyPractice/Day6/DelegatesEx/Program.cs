using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesEx
{
    class Program
    {
        public delegate void Del1();
        public delegate int DelAdd(int a, int b);
        static void Main1()
        {
           // Display();
            Del1 objDel = new Del1(Display);
            objDel();

            Console.ReadLine();
        }
        static void Main2()
        {

            Del1 objDel;
            objDel= new Del1(Display);
            objDel();
            objDel = new Del1(show);
            objDel();
            Console.ReadLine();
        }
        static void Main3()
        {
            Del1 objDel;
            objDel = new Del1(Display);
            objDel();
            Console.WriteLine();
            objDel += new Del1(show);
            objDel();
            Console.WriteLine();
            objDel += new Del1(Display);
           
            objDel();

            Console.WriteLine();
            objDel -= new Del1(Display);
           
            objDel();

            Console.ReadLine();
        }

        static void Main4()
        {
            Del1 objDel;
            objDel = Display;
            objDel();

            Console.WriteLine();
            objDel += show;
            objDel();

            Console.WriteLine();
            objDel += Display;
            objDel();

            Console.WriteLine();
            objDel += show;
            objDel();

            Console.WriteLine();
            objDel -= Display;
            objDel();

            Console.ReadLine();
        }
        static void Main5()
        {
            Del1 obj = (Del1)Delegate.Combine(new Del1(show),new Del1(Display), new Del1(show));
            obj();
            Console.WriteLine();
            obj = (Del1)Delegate.Remove(obj, new Del1(Display));
            obj();
            Console.WriteLine();
            obj = (Del1)Delegate.RemoveAll(obj, new Del1(show));
            obj();
            Console.ReadLine();
        }
        static void Main6()
        {
            DelAdd objDel = new DelAdd(Add);
            Console.WriteLine( objDel(20,30));

            Console.ReadLine();
        }

        static void Main()
        {

            Console.WriteLine(PassMethodToCallAsAParameter(new DelAdd(Add), 20, 10));
            Console.WriteLine();
            Console.WriteLine(PassMethodToCallAsAParameter(Add, 20, 10));
            Console.WriteLine();
            Console.WriteLine(PassMethodToCallAsAParameter(Sub, 20, 10));
            Console.WriteLine();
            Console.WriteLine(PassMethodToCallAsAParameter(Mul, 20, 10));
            Console.ReadLine();
        }
        static int PassMethodToCallAsAParameter(DelAdd objDelAdd, int a, int b)//objDelAdd = Add, a = 20, b = 10
        {
            return objDelAdd(a, b);
        }
        static void Display()
        {
            Console.WriteLine("Display 2!!");
        }
        static void show()
        {
            Console.WriteLine("showw ");
        }
        static int Add(int a,int b)
        {
            return a + b;

        }
        static int Sub(int a, int b)
        {
            return a - b;

        }
        static int Mul(int a, int b)
        {
            return a * b;

        }

    }
    public class Class2
    {
        public int Add(int a,int b)
        {
            return a + b;
        }
    }
}
