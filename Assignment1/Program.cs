using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee e = new Employee();
            //e.Name= "Ashwini";
            //Console.WriteLine(e.Name);
            //Console.WriteLine(Employee.EmpNo);




            Employee o1 = new Employee("Amol", 123465, 10);
            Employee o2 = new Employee("Amol", 123465);
            Employee o3 = new Employee("Amol");
            Employee o4 = new Employee();

            Console.WriteLine(o1.GetNetSalary());
            Console.WriteLine(o2.GetNetSalary());
            Console.WriteLine(o3.GetNetSalary());


            Console.WriteLine(o1.EmpNo);
            Console.WriteLine(o2.EmpNo);
            Console.WriteLine(o3.EmpNo);

            Console.WriteLine(o3.EmpNo);
            Console.WriteLine(o2.EmpNo);
            Console.WriteLine(o1.EmpNo);

            Console.ReadLine();
        }
    }
     
    public class Employee
    {
        private string name;
        public string Name
        {
            set
            {
                if (value == null)
                    Console.WriteLine("Null not allowed");
                else
                    name = value;
            }
            get
            {
                return name;
            }
        }
  
       private int empNo;
        public int EmpNo
        {
            get{return empNo;};
        }
        private decimal basic;
        public decimal Basic
        {
            set 
            { 
                if(value > 0 && value < 100000)
                    basic = value; 
                else
                    Console.WriteLine("Invalid sal");
            }
            get { return basic; }
        }
        private short dept;
        public short Dept
        {
            set
            {
                if (value > 0)
                    dept = value;
                else
                    Console.WriteLine("Invalid dept number");
            }
            get { return dept; }
        }

        
        private decimal sal;
        public decimal Sal
        {
            set { sal = value; }
            get { return sal; }
        }
        private decimal da=300;
        public decimal Da
        {
            set { da = value; }
            get { return da; }
        }
        public decimal GetNetSalary()
        {
          
        sal = basic + da;
            return sal;
        }
        static int id = 0;
       
        public Employee(string name="Noname",decimal basic=1000 ,short dept=10)
        {
            id++;
            this.EmpNo = id;
            this.name = name;
            this.basic = basic;
            this.dept = dept;

       }
       

    }

  
}
