using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicClassConcepts
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!!!");

            s1.Program1 ref1 = new s1.Program1();
            ref1.add();
           Console.WriteLine(ref1.Add(20, 30,10,20));

            Console.ReadLine();
        }
    }
}
namespace s1
{
   public class Program1
    {
        public void add()
        {
            System.Console.WriteLine("Do it ");

        }
        public int Add(int p=0,int q=0,int r=0,int s=80)
        {
            return p + q + r + s;
        }
    }
}