using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayEx
{
    class Program
    {
        static void Main()
        {
            Object[] arr1 = new Object[1];
            int numEmployee = 5;
            Employee[] arr = new Employee[numEmployee];
            Employee e1 = new Employee(1,"Ashwini", 9000);
            Employee e2 = new Employee(2,"Rani", 10000);
            Employee e3 = new Employee(3,"Rushi",38000);
            Employee e4 = new Employee(4,"Sanket", 11000);
            Employee e5 = new Employee(5,"Mahi", 20200);

            arr[0] = e1;
            arr[1] = e2;
            arr[2] = e3;
            arr[3] = e4;
            arr[4] = e5;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j].EmpSal > arr[j + 1].EmpSal)
                    {

                        Employee temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].EmpSal == arr[arr.Length - 1].EmpSal)
                    Console.WriteLine(arr[i].EmpId + " " + arr[i].EmpName + "  " + arr[i].EmpSal);
            }


            int eno = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].EmpId == eno)
                    Console.WriteLine(arr[i].EmpId + " " + arr[i].EmpName + "  " + arr[i].EmpSal);
            }





            Console.ReadLine();
        }


    }

    class Employee
        {
            private int empId;

            private string empName;
            private decimal empSal;

            public int EmpId
            {
                get;
                set;
            }
            public string EmpName { get; set; }
            public decimal EmpSal { get; set; }

            public Employee(int empId, string empName, decimal empSal)
            {
                this.EmpId = empId;
                this.EmpName = empName;
                this.EmpSal = empSal;
            }

        }
    }

