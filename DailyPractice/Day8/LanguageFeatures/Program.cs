using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Implicite variables
namespace LanguageFeatures
{
    class Program
    {
        static void Main1(string[] args)
        {
            int i;
            var i2 = "100"; //implicit variable;
           // i2 = 200;
            Console.WriteLine(i2.GetType().ToString());
            Console.ReadLine();
            //SortedList<int, string> obj = new SortedList<int, string>();
            //foreach (var item in obj)
            //{

            //}
        }
    }
}

namespace LanguageFeatures2
{
    public class Class1
    {
        public int i, j;
        public Class1()
        {
            i = 100;
            j = 200;
        }
        public Class1(int i,int j)
        {
            this.i = i;
            this.j = j;
        }
    }
    public class Program
    {
        static void Main()
        {
            Class1 o = new Class1();
            o.i = 232;
            o.j = 343;
            Class1 o2 = new Class1() { i = 24, j = 54 };
            Class1 o3 = new Class1() { i = 3,j=64 };

            Class1 o4 = new Class1(34,23) { i = 23, j = 56 };

        }
    }
}
namespace LanguageFeatures4
{
    class Program
    {
        static void Main4(string[] args)
        {
            int i=100;
            string s= "aa";
            i.display();
            s.show();
            Console.ReadLine();
            
        }
        static int reverse(int i)
        {
            int reverse = 9;
            //code
            return reverse;
        }
    }
    public static class MyclassExtension
    {
        public static void display(this int i)
        {
            Console.WriteLine(i);
        }
        public static void show(this string s)
        {
            Console.WriteLine("Aai");
        }
    }
}
