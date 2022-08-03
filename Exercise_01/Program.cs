using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_01
{
    class Program
    {
        static void Main(string[] args)
        {
        // A
        // ABA
        // ABCBA
        // ABCDCBA
        // ABCDEDCBA
        Get_Input:
            int lines = Convert.ToInt32(Console.ReadLine());
            if (lines > 26) 
            {
                Console.WriteLine("Lines must be less than 27");
                goto Get_Input; 
            }
            for (int i = 0; i <= lines; i++)
            {
                int str = 65;
                for (int j = 1; j < 2 * i; j++)
                {
                    if (j < i)
                    {
                        Console.Write(Convert.ToChar(str) + " ");
                        str++;
                    }
                    else
                    {
                        Console.Write(Convert.ToChar(str) + " ");
                        str--;
                    }

                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("\n---------------Sorting Array-----------------------\n");
            int[] array = new int[10] { 1, 9, 5, 3, 6, 8, 4, 2, 7, 0 };
            Program program = new Program();
            program.sortArr(array);

            Console.ReadLine();
        }

        public void sortArr(int[] arr)
        {
            //for (int i = 0; i < arr.Length - 1; i++)
            //{
            //    for (int j = 0; j < arr.Length - i - 1; j++)
            //    {

            //        if (arr[j] > arr[j + 1])
            //        {
            //            arr[j] ^= arr[j + 1];
            //            arr[j + 1] ^= arr[j];
            //            arr[j] ^= arr[j + 1];
            //        }
            //    }
            //}

            int[] sortedArr = new int[arr.Length];
            for(int i=arr.Length-1; i>=0; i--)
            {
                Array.Copy(arr, Array.IndexOf(arr, arr.Max()), sortedArr, i, 1);
                Array.Clear(arr, Array.IndexOf(arr, arr.Max()), 1);
            }

            foreach (int num in sortedArr)
            {
                Console.Write($"{num}  ");
            }
        }
    }
}
