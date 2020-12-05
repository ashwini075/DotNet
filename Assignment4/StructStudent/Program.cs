using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructStudent
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] arr = new Student[5];
            Console.WriteLine("Enter data:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter name of student:");
                arr[i].Name = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter marks");
                arr[i].Marks = Convert.ToDecimal(Console.ReadLine());
                arr[i] = new Student(arr[i].Name,arr[i].Marks);
            }
            for (int j = 0; j < arr.Length; j++)
            {
                arr[j].DisplayStudent();
            }
            Console.ReadLine();
        }
        struct Student
        {
            private string name;
            public string Name
            {
                set 
                { 
                    if(value != "")
                    name = value;
                    else
                        Console.WriteLine("Name should not be null");
                }
                get { return name; }
            }
            private int rollNo;
            public int RollNo
            {
                private set { rollNo = value; }
                get { return rollNo; }
            }
            private decimal marks;
            public decimal Marks
            {
                set
                {
                    if (value > 0 && value < 50)
                        marks = value;
                    else
                        Console.WriteLine("Enter valid marks");
                }
                get { return marks; }
            }
            private static int laststudent = 0;
            public Student(string name ="none",decimal marks=0)
            {
                rollNo = laststudent++;
                this.name = name;
               
                this.marks = marks;
                
            }
            public void DisplayStudent()
            {
                Console.WriteLine("");
                Console.WriteLine("The RollNo of Student is :" + rollNo);
                Console.WriteLine("The name of student is: " + name);
                Console.WriteLine("The marks of employee is: " + marks);

            }

        }
    }
}
