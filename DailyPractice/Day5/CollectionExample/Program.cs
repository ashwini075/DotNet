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
        static void Main1()
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
            oAl.Capacity=100;
            oAl.TrimToSize();
            bool isThere = oAl.Contains(30);
            foreach (object o in a1)
            {
                Console.WriteLine(o);
            }
        }
        
        static void Main2()
        {
            //Hashtable objDictionary = new Hashtable();
            SortedList objDictionary = new SortedList();
            objDictionary.Add(12, "sdsa");
            objDictionary.Add(13, "ujksa");
            objDictionary.Add(14, "suhkj");
            objDictionary.Add(15, "sdfyudta");
             objDictionary.Remove(3);

            ArrayList p = (ArrayList)objDictionary.GetKeyList();
            Console.WriteLine( objDictionary.GetByIndex(2));
           
        
            foreach (DictionaryEntry de in objDictionary)
            {
                Console.WriteLine(de.Key +" "+de.Value);
                //Console.WriteLine(de.Value);

            }
            objDictionary.Clear();
            Console.ReadLine();
        }
        static void Main3()
        {
            Stack objstack = new Stack();
            objstack.Push(232);
            objstack.Push(222);
            objstack.Push(200);
            objstack.Push(201);
            objstack.Push(202);
            objstack.Push(28);
            //Console.WriteLine(objstack.Peek());
            //Console.WriteLine(objstack.Pop());
            //Console.WriteLine(objstack.Peek());
            //Console.WriteLine(objstack.Pop());
            //Console.WriteLine(objstack.Peek());
            //Console.WriteLine(objstack.Pop());
           
            Queue objq = new Queue();
            objq.Enqueue(232);
            objq.Enqueue(343);
            Console.WriteLine(objq.Peek());
            Console.WriteLine(objq.Dequeue());
            Console.WriteLine(objq.Peek());
            Console.WriteLine(objq.Dequeue());
     
            Console.ReadLine();


        }
        static void Main4()
        {
            List<int> objList = new List<int>();
            objList.Add(14);
            objList.Add(33);
            objList.Add(12);
            objList.Add(39);
            foreach (int x in objList)
            {
                Console.WriteLine(x);
            }
            Console.ReadLine();

        }
        static void Main5()
        {
            SortedList<int, string> slist = new SortedList<int, string>();
            slist.Add(1, "df");
            slist.Add(2, "fvd");
            slist.Add(4, "kkjhg");
            foreach (KeyValuePair<int,string> x in slist)
            {
                Console.WriteLine(x.Key+" " +x.Value);
            }
        }
        static void Main6()
        {
            Stack<int> sobj = new Stack<int>();
            sobj.Push(34);
            sobj.Push(10);
            sobj.Push(90);
            sobj.Push(34);
            sobj.Push(30);
            sobj.Push(89);
            sobj.Pop();
         //   sobj.Reverse();
            foreach (Object x in sobj)
            {
                Console.WriteLine(x);
            }
            
            Queue<string> objq = new Queue<string>();
            objq.Enqueue("sds");
            objq.Enqueue("cvd");
            objq.Enqueue("dvd");
            foreach (Object x in objq)
            {
                Console.WriteLine(x);
            }
            Console.ReadLine();

        }
        static void Main7()
        {
            List<Employee> objEmps = new List<Employee>();
            //Employee obj = new Employee();
            //obj.EmpNo = 1;
            //obj.Name = "V";
            //obj.Basic = 12345;
            //obj.DeptNo = 10;
            //objEmps.Add(obj);

            //object initializer
            objEmps.Add(new Employee { EmpNo = 1, Name = "V", Basic = 12345, DeptNo = 10 });
            objEmps.Add(new Employee { EmpNo = 2, Name = "S", Basic = 12345, DeptNo = 10 });
            objEmps.Add(new Employee { EmpNo = 3, Name = "H", Basic = 12345, DeptNo = 10 });
            objEmps.Add(new Employee { EmpNo = 4, Name = "A", Basic = 12345, DeptNo = 10 });
            objEmps.Add(new Employee(5, "new") { Basic = 12345, DeptNo = 10 });


            foreach (Employee obj in objEmps)
            {
                Console.WriteLine(obj.Name);
            }
            Console.ReadLine();
        }
        static void Main8()
        {
            SortedList<int, Employee> objEmps = new SortedList<int, Employee>();
            objEmps.Add(1, new Employee { EmpNo = 1, Name = "V", Basic = 12345, DeptNo = 10 });
            objEmps.Add(2, new Employee { EmpNo = 2, Name = "S", Basic = 12345, DeptNo = 10 });
            objEmps.Add(3, new Employee { EmpNo = 3, Name = "H", Basic = 12345, DeptNo = 10 });
            objEmps.Add(4, new Employee { EmpNo = 4, Name = "A", Basic = 12345, DeptNo = 10 });

            foreach (KeyValuePair<int, Employee> kvp in objEmps)
            {
                Console.WriteLine(kvp.Key);
                Console.WriteLine(kvp.Value.Name);
            }
            Console.ReadLine();
        }
        static void Main()
        {
            Employees objemps = new Employees();
           
        }
    }
    public class Employees : List<Employee>
    {
        
    }
    public class Employee
    {
        public int EmpNo { get; set; }
        public string Name { get; set; }
        public decimal Basic { get; set; }
        public short DeptNo { get; set; }

        public Employee(int EmpNo = 1, string Name = "aaa")
        {
            this.EmpNo = EmpNo;
            this.Name = Name;
        }
    }

   

}
namespace p
{
    class class1
    {
        static void Main()
        {
            int i = 89;
            object o; //boxing
            o = i;
            int j;
            j = (int)o;//unboxing
        }
    }
}