using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpoverloadingEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 o = new Class1 { i = 30 };
            Class1 o1 = new Class1 { i = 20 };
            Class1 o2 = new Class1 { i = 10 };

            o = o + 5;
            o1 = o1 + o2;
            o2 = ++o;              //35
            Console.Write("++o : ");
            Console.WriteLine(o2.i);
            o2 = o++;              //36
            Console.Write("o++ : ");
            Console.WriteLine(o2.i);
           
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine(o.i);
            Console.WriteLine();
           Console.WriteLine(o1.i);
           Console.WriteLine(o2.i);
         

            Console.ReadLine();
        }
    }
    public class Class1
    {
        public int i;
        public static Class1 operator+(Class1 o,int i)
        {
            Class1 retVal = new Class1();
            retVal.i = o.i + i;
            return retVal;
        }
        public static Class1 operator +(Class1 o1, Class1 o2)
        {
            Class1 retVal = new Class1();
            retVal.i = o1.i + o2.i;
            return retVal;
        }
        public static Class1 operator ++(Class1 o)
        {
            Class1 retVal = new Class1();
            retVal.i = o.i++ ;
            return retVal;
        }
    }
}
