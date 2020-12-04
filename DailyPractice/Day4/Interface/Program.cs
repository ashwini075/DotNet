using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main1(string[] args)
        {
            Class1 o = new Class1();
            //method I
            o.Insert();
            o.Delete();
            o.Update();
            o.Display();
            Console.WriteLine();

            //method II
            IDbFunctions Idb;
            Idb = o;
            Idb.Insert();
            Console.WriteLine();
            //method III
            ((IDbFunctions)o).Update();

            Console.ReadLine();
        }
    }
    public interface IDbFunctions
    {
        void Insert();
        void Update();
        void Delete();

    }
    public class Class1 : IDbFunctions
    {
        public void Delete()
        {
            Console.WriteLine("class1 -Idb.Delete");
        }

        public void Insert()
        {
            Console.WriteLine("class1 -Idb.insert");
        }

        public void Update()
        {
            Console.WriteLine("class1 -Idb.update");
        }
        public void Display()
        {
            Console.WriteLine("Display");
        }
    }
}
namespace Interface1
{

    class Program
    {
        public static void Main1()
        {
            //method 1

           Class1 o = new Class1();
            o.Insert();
            Class2 o1 = new Class2();
            o1.Insert();
            Console.WriteLine();
            //method 2
            IDbFunctions Idb;
            Idb = o;
           Idb.Update();
            Idb = o1;
            Idb.Update();
            Console.ReadLine();
        }
        public static void Main2()
        {
            Class1 o1 = new Class1();
            Class2 o2 = new Class2();
            InsertMethod(o1);
            InsertMethod(o2);
            Console.ReadLine();
        }
        static void InsertMethod(IDbFunctions OIDb)
        {
            OIDb.Insert();
        }
    }
    public interface IDbFunctions
    {
        void Insert();
        void Update();
        void Delete();

    }
    public class Class1 : IDbFunctions
    {
        public void Delete()
        {
            Console.WriteLine("Class1-Delete");
        }

        public void Insert()
        {
            Console.WriteLine("Class1-Insert");
        }

        public void Update()
        {
            Console.WriteLine("Class1-Update");
        }
    }
    public class Class2 : IDbFunctions
    {
        public void Delete()
        {
            Console.WriteLine("class2 -Delete");
        }

        public void Insert()
        {
            Console.WriteLine("class2 -Insert");
        }

        public void Update()
        {
            Console.WriteLine("class2 -Update");
        }
    }
}
namespace Interface2
{
    public class MainClass
    {
        public static void Main()
        {
            Class1 o = new Class1();
            o.Close();

            IFileFunctions iff;
            iff = o;
            iff.Delete();
            IDbFunctions idb;
            idb = o;
            idb.Delete();
            Console.ReadLine();
        }
    }

    public interface IDbFunctions
    {
        void Insert();
        void Update();
        void Delete();

    }
    public interface IFileFunctions
    {
        void Open();
        void Close();
        void Delete();


    }
    public class Class1 : IDbFunctions, IFileFunctions
    {
        void IDbFunctions.Delete()
        {
            Console.WriteLine("IDbfunction -delete");
        }

        public void Insert()
        {
            Console.WriteLine("IDbfunction -  Insert");
        }

        public void Update()
        {
            Console.WriteLine("IDbfunction - Update");
        }

       public void Close()
        {
            Console.WriteLine("IFileFunctions close");
        }

        void IFileFunctions.Delete()
        {
            Console.WriteLine("IFileFunctions Delete");
        }

       public void Open()
        {
            Console.WriteLine("IFileFunctions open");
        }
    }
}
