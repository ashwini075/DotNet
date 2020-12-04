using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMembers
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 o = new Class1();
            Class1.i = 3432;
            o.j = 34;
            o.Display();

            Console.WriteLine(Class1.i);

            Console.ReadLine();
        }
    }
    //        static constructor? -> initialise static members

    //called when the class is loaded into memory(either 1st object created or a static member accessed
    //implicitly called(implicitly private)
    //cannot have parameters
    //cant be overloaded
    public class Class1
    {
        static Class1()
        {
            Console.WriteLine("static constt");
            
        }
        public static int i;
        public int j;
        public void Display()
        {
            Console.WriteLine("you are in Display function");
            Console.WriteLine(i); //static members are allowed in non static methods 
            Console.WriteLine(j);
            i++;
        }

        public static void S_Display()
        {
            Console.WriteLine("you are in Display function");
            Console.WriteLine(i);
           // Console.WriteLine(j);  //non static members are not allowed in static method 
        }
    }
}
