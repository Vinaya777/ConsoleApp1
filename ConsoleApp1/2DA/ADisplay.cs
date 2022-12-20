using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1._2DA
{
    class ADisplay
    {
        static void Main(string[] args)
        {
            int[,] arr = { { 2, 4, 5 }, { 7, 8, 1 }, { 9, 8, 5 }, { 5, 10, 15 } };

            int[,] a = new int[4,3];
            Console.WriteLine("enter the array elements:");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("XOXOXOXOXOXOXOOXOXOOXOXOXOXOXOXOXOXOXXOOXOXOXOXOX");
            ///wirtten array
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.WriteLine(a[i, j] + "  ");

                }
                Console.WriteLine();
            }
            Console.WriteLine("XOXOXOOXOXOOXOXOOXOXOXOXOXOXOXOXOXOXXOXOXOXOXOXOXOXOOXOOXOXOOXOX");
            // array Display
            for(int i = 0; i <= a.GetLength(0); i++)
            {
                for(int j = 0; j <= a.GetLength(1); j++)
                {
                    Console.WriteLine(a[i, j] + " ");

                }
                Console.WriteLine();
            }
        }
    }
}