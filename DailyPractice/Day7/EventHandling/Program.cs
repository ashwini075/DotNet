using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 objClass1 = new Class1();
            objClass1.InvalidP1 += objClass1_InvalidP1;
            objClass1.P1 = 2334;
            Console.ReadLine();
        }
        static void objClass1_InvalidP1()
        {
            Console.WriteLine("Invalid p1 event");
        }
        
    }
    // step 1- create delegate class has same signature as event handler

    public delegate void InvalidP1EventHandler();

    //programmer code 
    public class Class1
    {
      
        //step 2- Declare delegate object
        public event InvalidP1EventHandler InvalidP1;
        private int p1;
        public int P1
        {
            get { return p1; }
            set 
            { 
                if (value < 100)
                    p1 = value;
                else
                { 
                    //raise the event here
                    //step 3-call the delegate object
                    InvalidP1();
                }
            }
        }
    }
}
