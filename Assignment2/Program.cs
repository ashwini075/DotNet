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
            Manager o = new Manager("Ashwini",10000,2,"QualityManager");
            Console.WriteLine( "Name:"+o.Name+"   Salary:"+o.CalNetSalary());

            GeneralManager o1 = new GeneralManager("Ankita", 20000, 3, "PL", "health");
            Console.WriteLine("Name:" + o1.Name + "   Salary:" + o1.CalNetSalary());

            CEO o2 = new CEO("Manvi", 25000, 4); 
            Console.WriteLine("Name:" + o2.Name + "   Salary:" + o2.CalNetSalary());

            Console.ReadLine();
        }
    }
    public abstract class Employee
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
            { return name; }
            
        }
        private int empNo;
        public int EmpNo
        {
            get;
        }
        private decimal basic;
        public abstract decimal Basic
        { get; set; }

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


    
        public abstract decimal CalNetSalary();
       
        static int id = 0;

        public Employee(string name = "Ash", decimal basic = 1000, short dept = 10)
        {
            id++;
            this.EmpNo = id;
            this.Name = name;
            this.Basic = basic;
            this.Dept = dept;

        }

    }
    public class Manager : Employee
    {
        private string designation;
        public string Designation
        {
            set
            {
                if (value == null)
                    Console.WriteLine("Null not allowed");
                else
                    designation = value;
            }
            get
            {
                return designation;
            }
        }
        public override decimal Basic { get; set; }

        public override decimal CalNetSalary()
        {
            Console.WriteLine("manager calnetsal");
            decimal DA = 200;
            decimal Sal = Basic + DA;
            return Sal;
        }
        
        public Manager(string name, decimal basic,short dept,string designation):base(name,basic,dept)
        {
            this.Designation = designation;

        }
    }
    public class GeneralManager : Manager
    {
        private string perks;
        public string Perks
        {
            set { perks = value; }
            get { return perks; }
        }
        public GeneralManager(string name, decimal basic, short dept, string designation,string perks):base(name,basic,dept,designation)
        {
            Console.WriteLine("In GeneralManger class");
            this.Perks = perks;
        }
    }
    public class CEO : Employee
    {

        public override decimal Basic { set; get; }

        public sealed override decimal CalNetSalary()
        {
            Console.WriteLine("CEO calnetsal");
           decimal DA=500;
            decimal Sal = Basic + DA ;
            return Sal;
        }
        public CEO(string name,decimal basic,short dept):base(name,basic,dept)
        {
            Console.WriteLine("In CEO class");
        }

    }
}
