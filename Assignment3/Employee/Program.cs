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
            Manager o = new Manager("Ashwini", 10000, 2, "QualityManager");
            Console.WriteLine("Name:" + o.Name + "   Salary:" + o.CalNetSalary());
            o.Insert();
            o.Update();
            o.Delete();
            Console.WriteLine();
            GeneralManager o1 = new GeneralManager("Ankita", 20000, 3, "PL", "health");
            Console.WriteLine("Name:" + o1.Name + "   Salary:" + o1.CalNetSalary());
            o1.Insert();
            o1.Update();
            o1.Delete();
            Console.WriteLine();
            CEO o2 = new CEO("Manvi", 25000, 4);
            Console.WriteLine("Name:" + o2.Name + "   Salary:" + o2.CalNetSalary());
            o2.Insert();
            o2.Update();
            o2.Delete();
            Console.ReadLine();
        }
    }
    public interface IDbFunctions
    {
        void Insert();
        void Update();
        void Delete();

    }
    public abstract class Employee:IDbFunctions
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
        protected decimal basic;
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

        public void Insert()
        {
            Console.WriteLine("Insert in Employee class");
        }

        public void Update()
        {
            Console.WriteLine("Update in Employee class");
        }

        public void Delete()
        {
            Console.WriteLine("Delete in Employee class");
        }

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
    public class Manager : Employee, IDbFunctions
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

      void IDbFunctions.Insert()
        {
            Console.WriteLine("Insert in Manager class");
        }

       public new void Update()
        {
            Console.WriteLine(" Update in Manager class");
        }

       public new void Delete()
        {
            Console.WriteLine("Delete in Manager class");
        }

        public Manager(string name = "Ash", decimal basic = 1000, short dept = 10, string designation = "M") : base(name, basic, dept)
        {
            this.Designation = designation;

        }
    }
    public class GeneralManager : Manager,IDbFunctions
    {
        private string perks;
        public string Perks
        {
            set { perks = value; }
            get { return perks; }
        }
        public GeneralManager(string name = "Ash", decimal basic = 1000, short dept = 10, string designation = "GM", string perks = "none") : base(name, basic, dept, designation)
        {
            Console.WriteLine("In GeneralManger class");
            this.Perks = perks;
        }
        public new void Insert()
        {
            Console.WriteLine("Insert in GManager class");
        }

        public new void Update()
        {
            Console.WriteLine("Update in GManagerclass");
        }

        public new void Delete()
        {
            Console.WriteLine("Delete in GManager class");
        }

       
    }
    public class CEO : Employee,IDbFunctions
    {

        public override decimal Basic { set; get; }

        public sealed override decimal CalNetSalary()
        {
            Console.WriteLine("CEO calnetsal");
            decimal DA = 500;
            decimal Sal = Basic + DA;
            return Sal;
        }
        public CEO(string name = "none", decimal basic = 1000, short dept = 10) : base(name, basic, dept)
        {
            Console.WriteLine("In CEO class");
        }
        void IDbFunctions.Insert()
        {
            Console.WriteLine("Insert In CEO class");
        }

        public new void Update()
        {
            Console.WriteLine("Update In CEO class");
        }

        public new void Delete()
        {
            Console.WriteLine("Delete In CEO class");
        }

       
    }
}
