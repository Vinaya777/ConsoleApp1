using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1._2DArray
{
    class SumRow
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the row and coloum to have 2D-Array");
            Console.WriteLine("Enter the row");
            int row = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the coloum");
            int cols = int.Parse(Console.ReadLine());

            int[,] a = new int[4, 4];
            Console.WriteLine("Enter array elemnets:");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Sum of each row elements...");

            for (int i = 0; i < a.Length; i++)
            {
                int sum = 0;
                for (int j = 0; j < a.Length; j++)
                {
                    sum += a[i, j];
                }
                Console.WriteLine("row " + (i + 1) + "elements sum is" + sum);
            }

        }
    }
}