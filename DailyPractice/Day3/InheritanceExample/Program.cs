using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//taking user i/p various ways
namespace InheritanceExample
{
    class Program
    {
        //reading data from console
        static void Main1()
        {
            int i;
            i = int.Parse(Console.ReadLine());

            decimal d;
            d = decimal.Parse(Console.ReadLine());

            i = Convert.ToInt32(Console.ReadLine());
        }
    }
}

//constructor working
namespace InheritanceExample1
{
    class Program
    {
         static void Main1()
         {
            // DerivedClass o = new DerivedClass();
            DerivedClass o2 = new DerivedClass(123, 45666);
            Console.ReadLine();
         }
    }

    public class BaseClass
    {
        public int i;
        public BaseClass ()
	    {
            Console.WriteLine("In base class");
            i=90;
	    }
        public BaseClass (int i)
	    {
            Console.WriteLine("In int base class");
            this.i=i;
	    }
    }
    public class DerivedClass :BaseClass
    {
        public int j;
        public DerivedClass ()
	    {
            Console.WriteLine("In derived class");
            j=80;

	    }
        //base used for explicity calling the parameterized constr of baseclass

        public DerivedClass (int i,int j):base(i)
	    {
            Console.WriteLine("In derived int ");
            this.j=j;
	    }
    }
}

//overloading,hiding,overriding,sealed
namespace InheritanceExample2
{
    class Program
    {
        static void Main1()
        {
            DerivedClass o = new DerivedClass();
            o.Display();
            o.Display("sai");
            o.Display1();
            o.Display2();         
                                //Base display
                                //Derived class display
                                //Derived class display1
                                //Derived class display2

            Console.ReadLine();
        }
        static void Main2()
        {
            BaseClass o;
            o = new BaseClass();
            o.Display1();
            o.Display2();
            Console.WriteLine();

            o = new DerivedClass();
            o.Display1();
            o.Display2();
            Console.WriteLine();

            o = new SubDerived();
            o.Display1();
            o.Display2();
            Console.WriteLine();

            o = new SubSubderived();
            o.Display1();
            o.Display2();
            Console.WriteLine();

            Console.ReadLine();
        }
    }
    public class BaseClass
    {
        public void Display()
        {
            Console.WriteLine("Base display");
        }
        public void Display1()
        {
            Console.WriteLine("Base Display1");
        }
        public virtual void Display2()
        {
            Console.WriteLine("Base Display2");
        }
    }
    public class DerivedClass : BaseClass
    {
        //overload
        public void Display(string a)
        {
            Console.WriteLine("Derived class display");
        }
        //Hiding 
        public new void Display1()
        {
            Console.WriteLine("Derived class display1");
        }
        public override void Display2()
        {
            Console.WriteLine("Derived class display2");
        }
    }
    public class SubDerived : DerivedClass
    {
        public override void Display2()
        {
            Console.WriteLine("subderived class");
        }
    }
    public class SubSubderived :SubDerived
    {
        public new void Display2()
        {
            Console.WriteLine("In Sub Subderived");
        }
    }


}
namespace InheritanceExample3
{
    class Program
    {
        static void Main()
        {
            DerivedClass o = new DerivedClass();
            o.Display();
            o.show();
            Console.WriteLine();
            Class2 o1 = new Class2();
            o1.Display();


            Console.ReadLine();
        }
    }
    public abstract class Abstractclass
    {
        public void Display()
        {
            Console.WriteLine("display from abstract");
        }
    }
    public class DerivedClass : Abstractclass
    {
        public void show()
        {
            Console.WriteLine("ashwini ");
        }
    }

    public abstract class AbstractClass2
    {
        public abstract void Display();
        public abstract void show();
    }
    public  class Class2 : AbstractClass2
    {
        public override void Display()
        {
            Console.WriteLine("display");
        }

        public override void show()
        {
            Console.WriteLine("show");
        }
    }
}