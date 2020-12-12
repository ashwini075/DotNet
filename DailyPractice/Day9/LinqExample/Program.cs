using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExample
{
    class Program
    {
        static List<Department> lstDept = new List<Department>();

        static List<Employee> lstEmp = new List<Employee>();

        static void Main1(string[] args)
        {
            AddRec();
            var emps = from emp in lstEmp select emp;
            
            foreach (var emp in emps)
            {
                Console.WriteLine(emp);
            }
            foreach (var emp in emps)
            {
                Console.WriteLine(emp.Name);
            }
        }
        static void Main2(string[] args)
        {
            AddRec();
            var emps = from emp in lstEmp select new { emp.Name, emp.Basic };
           
            foreach (var emp in emps)
            {
                Console.WriteLine(emp.Name);
                Console.WriteLine(emp.Basic); 
            }

        }
        static void Main3(string[] args)
        {
            AddRec();
            var emps = from emp in lstEmp select emp.Name;
           
            foreach (var emp in emps)
            {
                Console.WriteLine(emp);
            }
            Console.ReadLine();
        }
        static void Main4(string[] args)
        {
            AddRec();
           // var emps = from emp in lstEmp where emp.Basic > 1000 select emp ;
            var emps= from emp in lstEmp where emp.Basic > 10000 && emp.Basic < 12000 select emp;

            foreach (var emp in emps)
            {
                Console.WriteLine(emp.Name);
            }
            Console.ReadLine();
        }
        static void Main5(string[] args)
        {
            AddRec();
            // var emps = from emp in lstEmp where emp.Basic > 1000 select emp ;
            //var emps = from emp in lstEmp where emp.Basic > 10000 && emp.Basic < 12000 select emp;
            //var emps = from emp in lstEmp
            //           where emp.Name.StartsWith("V")
            //           select emp;
            var emps = from emp in lstEmp 
                       orderby emp.DeptNo, emp.EmpNo descending 
                       select emp;
            foreach (var emp in emps)
            {
                Console.WriteLine(emp.Name);
            }
            Console.ReadLine();
        }
        static void Main()
        {
            AddRec();
            var emps = from emp in lstEmp
                       join dept in lstDept
                       on emp.DeptNo equals dept.DeptNo
                       select new { dept.DeptName, emp.Name };
            foreach (var emp in emps)
            {
                Console.WriteLine(emp.Name );
            }
            Console.ReadLine();
        }
        public static void AddRec()
        {
            lstDept.Add(new Department { DeptNo = 1,DeptName = "TRN" });
            lstDept.Add(new Department { DeptNo = 2, DeptName = "MKT" });
            lstDept.Add(new Department { DeptNo = 3, DeptName = "SALE" });
            lstDept.Add(new Department { DeptNo = 4, DeptName = "DEV" });

            lstEmp.Add(new Employee { EmpNo = 1, Name = "Vikram", Basic = 10000, DeptNo = 10, Gender = "M" });
            lstEmp.Add(new Employee { EmpNo = 2, Name = "Vikas", Basic = 11000, DeptNo = 10, Gender = "M" });
            lstEmp.Add(new Employee { EmpNo = 3, Name = "Abhijit", Basic = 12000, DeptNo = 20, Gender = "M" });
            lstEmp.Add(new Employee { EmpNo = 4, Name = "Mona", Basic = 11000, DeptNo = 20, Gender = "F" });
            lstEmp.Add(new Employee { EmpNo = 5, Name = "Shweta", Basic = 12000, DeptNo = 20, Gender = "F" });
            lstEmp.Add(new Employee { EmpNo = 6, Name = "Sanjay", Basic = 11000, DeptNo = 30, Gender = "M" });
            lstEmp.Add(new Employee { EmpNo = 7, Name = "Arpan", Basic = 10000, DeptNo = 30, Gender = "M" });
            lstEmp.Add(new Employee { EmpNo = 8, Name = "Shraddha", Basic = 11000, DeptNo = 40, Gender = "F" });


        }
    }
    
    public class Department
    {
        public int DeptNo { get; set; }
        public string DeptName { get; set; }
    }
    public class Employee
    {
        public int EmpNo { get; set; }
        public string Name { get; set; }
        public decimal Basic { get; set; }
        public int DeptNo { get; set; }
        public string Gender { get; set; }
    }
}
