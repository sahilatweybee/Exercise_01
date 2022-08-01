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

            for (int i = 0; i <= 5; i++)
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
            Console.ReadLine();
        }
    }
}
