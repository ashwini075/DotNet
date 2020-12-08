using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambdas
{
    class Program
    {
        static void Main(string[] args)
        {
            //x is parameter of func
            //=> is lambda operator
            //x*2 is return value
            Func<int, int> o = (x) => x * 2;
            Console.WriteLine(o(20));

            Func<int, int, int> o1 = (a, b) => a + b;
            Console.WriteLine(o1(20, 10));

            Func<int, int, int, int> o2 = (a, b, c) =>
            {
                //multiple lines
               return a + b + c;
            };

            Console.WriteLine(o2(20, 10,30));

            Console.ReadLine();

        }
        static int MakeDouble(int a)
        {
            return a * 2;
        }
        static int Add(int a, int b)
        {
            return a + b;
        }
    }
}
