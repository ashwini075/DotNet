using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main1()
        {
            int[] arr = new int[4];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter {0}:",i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach (int x in arr)
            {
                Console.WriteLine("Value is {0}",x);
            }
        }
        static void Main2()
        {
            int[] arr = new int[4];
            int[] arr2 = new int[5];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter {0}:", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            //Array.Clear(arr, 1, 1);
            // Array.Copy(arr, arr2, arr.Length);
           
            //int pos = Array.IndexOf(arr, 39);
            //Console.WriteLine(pos);
            //int pos1 = Array.LastIndexOf(arr, 3);
            //Console.WriteLine(pos1);
            //Array.Reverse(arr);
            //Array.Sort(arr);
           int pos= Array.BinarySearch(arr, 20);
            Console.WriteLine(pos);
            foreach (int x in arr)
            {
                Console.WriteLine("Value is {0}", x);
            }
        }
        static void Main3()
        {
            int[,] arr = new int[5, 3];

            Console.WriteLine(arr.Length);


            Console.WriteLine(arr.Rank);
            Console.WriteLine(arr.GetLength(0));
            Console.WriteLine(arr.GetLength(1));

            Console.WriteLine(arr.GetUpperBound(0));
            Console.WriteLine(arr.GetUpperBound(1));


            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("Enter marks for student number {0} and subject {1} ", i, j);
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine();
            //foreach (int x in arr)
            //{
            //    Console.WriteLine(x);
            //}

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Marks for student number {0} and subject {1} is {2}", i, j, arr[i, j]);
                }
            }
            Console.ReadLine();
        }
        static void Main()
        {
            //jagged array
            int[][] arr = new int[5][];
            arr[0] = new int[3]; // arr[0][0]- arr[0][2]
            arr[1] = new int[4];
            arr[2] = new int[2];
     
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write("enter subscript [{0}][{1}] : ", i, j);
                    arr[i][j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.WriteLine("value  {0},{1} is {2}  ", i, j, arr[i][j]);

                }
            }
            Console.ReadLine();
        }
    }
}
