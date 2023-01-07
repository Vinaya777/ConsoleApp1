using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1._2DA
{
    class For2D
    {
        static void Main(string[] args)
        {
            int[,] arr2d = new int[3, 4];
            Console.WriteLine($"Length of 2D{arr2d.Length}");
            for (int r = 0; r < arr2d.GetLength(0); r++)
            {
                Console.WriteLine("Enter the elements for row");
                for (int c = 0; c < arr2d.GetLength(1); c++)
                {
                    arr2d[r, c] = int.Parse(Console.ReadLine());
                }
            }
            for (int r = 0; r < 3; r++)
            {

                for (int c = 0; c < 4; c++)
                {
                    Console.Write(arr2d[r, c] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}