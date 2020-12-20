using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo
{

    //sealed class 
    class Program
    {
        static void Main1(string[] args)
        {
            sealedclass s = new sealedclass();
            s.display();
        }
    }
    sealed class sealedclass
    {
        public void display()
        {
            Console.WriteLine("Display sealed class");
        }
    }
   

}
namespace ToDO1
{
    public interface A
    {
        void method1();
        void method2();
    }
    public interface B : A
    {
        void method3();
    }
    public interface C: B
    {
       void method4();
    }
    public class Class1 : C
    {
        public void method1()
        {
            Console.WriteLine("method 1");
        }

        public void method2()
        {
            Console.WriteLine("method 2");
        }

        public void method3()
        {
            Console.WriteLine("method 3");
        }

        public void method4()
        {
            Console.WriteLine("method 4");
        }
    }
    class Program
    {
        public static void Main()
        {
            Class1 c = new Class1();
            c.method1();
            c.method2();
            c.method3();
            c.method4();

        }
    }

}
