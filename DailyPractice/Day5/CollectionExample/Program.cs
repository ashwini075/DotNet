using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionExample
{
    class Program
    {
        static void Main()
        {
            ArrayList oAl = new ArrayList();
            oAl.Add(30);
            oAl.Add("Sai");
            oAl.Add("Ram");
            oAl.Add(200.33);

          //  Console.WriteLine(oAl.Count);
            //oAl.Remove(30);
            //oAl.RemoveAt(1);
            //oAl.Clear();
          
            ArrayList a1 = new ArrayList();
            a1.AddRange(oAl);
           
            foreach (object o in a1)
            {
                Console.WriteLine(o);
            }
        }
    }
}
