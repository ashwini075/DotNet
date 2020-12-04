using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBasicc
{
    class Program
    {
        static void Main1(string[] args)
        {
            Class1 o = new Class1();
            //Console.WriteLine(o.i);


            //o.SetI(45);
            //Console.WriteLine(o.GetI());

            o.P1 = 20;
            Console.WriteLine(o.P1);

            o.P2 = "Hello Ashuu!!";
            Console.WriteLine(o.P2);


            Console.WriteLine(o.P3);
            o.P4 = 3432;
            Console.WriteLine(o.P4);
            Console.ReadLine();
        }
        static void Main()
        {
            Class1 o = new Class1();
            Console.WriteLine("===========");
            Class1 o1 = new Class1(67);
            Console.ReadLine();
            Console.WriteLine(o.P1);
            Console.WriteLine(o1.P1);
            o = null;
            o1 = null;
            Console.ReadLine();
            GC.Collect();
            Console.ReadLine();
        }
    }
    public class Class1
    {
        #region Constructors 
        public Class1()
        {
            Console.WriteLine("non param cons called");
              P1 = 5;

        }
        public Class1(int P1)
        {
            Console.WriteLine("parametrized const");
            this.P1 = P1;

        }
        #endregion
        ~Class1()
        {
            Console.WriteLine("DES");
        }




        private int i;
        public void SetI(int x)
        {
            if (x < 100)
                i = x;
            else
                Console.WriteLine("invalid value");
        }
        public int GetI()
        {
            return i;
        }

        //property
        private int p1;
        public int P1
        {
            set   ////gets called when   o.P1 = 10;
            {
                if (value < 70)
                    p1 = value;
                else
                    Console.WriteLine("invalid P1");
            }
            get 
            {
                return p1;
            }
        }
        private string p2;
        public string P2
        {
            set { p2 = value; }
            get { return p2; }
        }


        //read only property
        //using get we make it read only

        private string p3 = "sai bless you";
        public string P3
        {
            get { return p3; }
        }

        //auto property
        public int P4 { get; set; }

    }
}
