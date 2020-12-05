using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*CDAC has certain number of batches. each batch has certain number of students
accept number of batches from the user. for each batch accept number of students.
         create an array to store mark for each student. 
         accept the marks.
         display the marks.*/
namespace CdacStudents
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter number batches");
            int num = Convert.ToInt32(Console.Read());
            int[][] arr = new int[num][];

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine($"Enter No. of Students in Batch {i+1} :");
                int stud = Convert.ToInt32(Console.Read());
                arr[i] = new int[stud];
                for (int j = 0; j < stud; j++)
                {
                    Console.WriteLine($"Enter marks for Batch {i+1} student {j+1} =");
                    arr[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j< arr[i].Length; j++)
                {
                    Console.WriteLine("Batch {0} :: Student No = {1} ::: Marks ={2} :",i+1,j+1,arr[i][j]);
                }
            }
        }
    }
}
