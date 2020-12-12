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
//object Initalizers
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
        static void Main2()
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
//anonymous type
namespace LanguageFeatures3
{
    class Program
    {
        static void Main() // ANONYMOUS TYPES
        {
            //Class1 o = new Class1();
            //Class1 o3 = new Class1 { i = 123, j = 456 };
            var myCar = new { Color = "Red", Model = "Ferrari", Version = "V1", CurrentSpeed = 75 };

            var myCar2 = new { Color = "Blue", Model = "Merc", Version = "V2" };

            Console.WriteLine("{0} {1} {2} {3}", myCar.Color, myCar.Model, myCar.Version, myCar.CurrentSpeed);

            Console.WriteLine(myCar.GetType().ToString());
            Console.WriteLine(myCar2.GetType().ToString());

            Console.ReadLine();
        }

    }
}
//
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
//partial methods
namespace PartialMethods
{
    public class MainClass
    {
        public static void Main()
        {
            Class1 o = new Class1();
            Console.WriteLine(o.Check());
            Console.ReadLine();
        }
    }

    //Partial methods can only be defined within a partial class.
    //Partial methods must return void.
    //Partial methods can be static or instance level.
    //Partial methods cannnot have out params
    //Partial methods are always implicitly private.
    public partial class Class1
    {
        private bool isValid = true;
        partial void Validate();
        public bool Check()
        {
            //.....
            Validate();
            return isValid;
        }
    }

    public partial class Class1
    {
        partial void Validate()
        {
            //perform some validation code here
            isValid = false;
        }
    }

}

