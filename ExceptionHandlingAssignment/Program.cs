using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employees> li = new List<Employees>();
            Employees emp = new Employees();
            try
            {
                char choice = 'y';
                while (choice == 'y')
                {
                    Employees.insertEmployee(li);
                    Console.WriteLine("Do you want to continue type 'y'/'n': ");
                    choice = Convert.ToChar(Console.ReadLine());

                }
            }
            catch (InvalidEmpIdException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(InvalidEmpNameException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(InvalidEmpSalException ex)
            {
                Console.WriteLine(ex.Message);
            }catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Enter valid input");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Employees[] arr = li.ToArray();


            foreach (Employees item in arr)
            {
                Console.WriteLine("EMpId="+item.EmpId+" "+item.EmpName+" "+item.EmpSal);
                    
            }
            Console.ReadLine();
        }
    }
    class Employees
    {
        private int empId;
        private string empName;
        private decimal empSal;
        public int EmpId
        {
            get { return empId; }
            set
            {
                if (value < 20)
                    empId = value;
                else
                {
                    Exception ex;
                    ex = new InvalidEmpIdException("Invalid Employee Id");
                    throw ex;

                }
            }
        }

        public string EmpName
        {
            get { return empName; }
            set
            {
                if (value != null)
                    empName = value;
                else
                {
                    Exception ex;
                    ex = new InvalidEmpNameException("Invalid Name");
                }

            }
        }
        public decimal EmpSal
        {
            get { return empSal; }
            set
            {
                if (value > 10000)
                    empSal = value;
                else
                {
                    Exception ex;
                    ex = new InvalidEmpSalException("Invalid Sal");
                }

            }
        }
        public Employees(int empId, string empName, decimal empSal)
        {
            this.EmpId = empId;
            this.EmpName = empName;
            this.EmpSal = empSal;
        }
        public Employees()
        {

        }
        public static void insertEmployee(List<Employees> li)
        {
            Employees emp = new Employees();

            Console.WriteLine("Enter EMployee Id: ");
            int empId = Convert.ToInt32(Console.ReadLine());
            emp.EmpId = empId;

            Console.WriteLine("Enter Employee Name: ");
            string empName = Console.ReadLine();
            emp.EmpName = empName;

            Console.WriteLine("Enter EMployee Salary: ");
            decimal empSal = Convert.ToDecimal(Console.ReadLine());
            emp.EmpSal = empSal;

            li.Add(new Employees(empId, empName, empSal));
        }


    }
    public class InvalidEmpIdException : ApplicationException
    {
        public InvalidEmpIdException(string message) : base(message)
        {

        }
    }
    public class InvalidEmpNameException : ApplicationException
    {
        public InvalidEmpNameException(string message) : base(message)
        {

        }
    }
    public class InvalidEmpSalException : ApplicationException
    {
        public InvalidEmpSalException(string message) : base(message)
        {

        }
    }
}