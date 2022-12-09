using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1._2DArray
{
    class FindRow
    {
        public void FindRowmatrix(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                int sum = 0;

                for (int j = 0; j < a.GetLength(1); j++)
                {
                    sum = sum + a[i, j];
                    Console.WriteLine(a[i, j] + " ");

                }
                Console.WriteLine("=" + sum);
                Console.WriteLine();
            }
        }
        public void FindColoummatrix(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    sum = sum + a[i, j];
                    Console.WriteLine(a[i, j] + " ");
                }
                Console.WriteLine(" = " + sum);
                Console.WriteLine();
            }
        }
        public void FindMAxValue(int[,] a)
        {
            for (int i = 0; i < a.GetLength(1); i++)
            {
                int max = a[1, 0];
                for (int j = 0; j < a.GetLength(0); j++)
                {
                    if (a[j, i] > max)
                    {
                        max = a[i, j];
                    }
                    Console.WriteLine("max=" + max);
                    Console.WriteLine();

                }
            }
        }
        static void Main(string[] args)
        {

            int[,] a = { { 7, 14, 21 }, { 28, 35, 42 }, { 49, 56, 63 } };
            FindRow fr = new FindRow();
            fr.FindRowmatrix(a);
            fr.FindMAxValue(a);

        }
    }
}
