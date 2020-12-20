using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Write lambdas for the following functions :
1. decimal SimpleInterest(decimal P, decimal N, decimal R) -> returns calculated SimpleInterest
2. bool IsGreater(int a, int b) -> returns true if a is > b
3. decimal GetBasic(Employee e) -> returns the Basic salary of the employee
4. bool IsEven(int num) -> returns true if the number is an even number
5. bool IsGreaterThan10000(Employee e) -> returns true if the Basic Salary is > 10000 */

namespace LambdaAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. decimal SimpleInterest(decimal P, decimal N, decimal R) -> returns calculated SimpleInterest

            Func<decimal, decimal, decimal, decimal> o = (P, N, R) => ((P * N * R) / 100 ) ;
            Console.WriteLine(o(1000, 2, 6));

            //2. bool IsGreater(int a, int b) -> returns true if a is > b
            Func <int, int,bool> o1 = (a, b) => a > b;
            Console.WriteLine(o1(30,87));

            //3. decimal GetBasic(Employee e) -> returns the Basic salary of the employee
            Func<Employee, decimal> o2 = Employee => Employee.Basic;
            Console.WriteLine(o2 (new Employee("dcs",20000)));

            //4. bool IsEven(int num) -> returns true if the number is an even number
            Func<int, bool> o3 = num => (num%2 ==0);
            Predicate<int> p = num => num % 2==0;
            Console.WriteLine(p(44));
            Console.WriteLine(o3(45));

            // bool IsGreaterThan10000(Employee e) -> returns true if the Basic Salary is > 10000 */
            Func<Employee, bool> o4 = Employee => Employee.Basic > 1000;
            Console.WriteLine(o4(new Employee("dcs", 800)));

            Console.ReadLine();
        }
       
    }
    public class Employee
    {
        private decimal basic;
        private string empName;
        public decimal Basic
        {
            get { return basic; }
            set { basic = value; }
        }
        public Employee(string empName, decimal basic)
        {
            this.empName = empName;
            this.basic = basic;
        }

    }
}
