using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            SortedList<int, string> obj = new SortedList<int, string>();
            foreach (var item in obj)
            {

            }
        }
    }
}
namespace LanguageFeatures4
{
    class Program
    {
        static void Main(string[] args)
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
