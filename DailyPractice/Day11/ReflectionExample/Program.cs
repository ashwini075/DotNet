using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //  C: \Users\Admin\Downloads\Day11\OpOverloadingEg\bin\Debug\OpOverloadingEg

            Assembly asm = Assembly.LoadFrom(@"C:\Users\Admin\Downloads\Day11\OpOverloadingEg\bin\Debug\OpOverloadingEg.exe");

            // Console.WriteLine(asm.FullName);
            // Console.WriteLine(asm.GetName().Name);

            Type[] arr = asm.GetTypes();
            foreach (Type t in arr)
            {
                Console.WriteLine(" "+t.Name);
               // Console.WriteLine("============");
                MethodInfo[] arrmethods = t.GetMethods();
                foreach (MethodInfo m in arrmethods)
                {
                    Console.WriteLine( "  "+m.Name);
                }
            }
            Console.ReadLine();
        }
    }
}
