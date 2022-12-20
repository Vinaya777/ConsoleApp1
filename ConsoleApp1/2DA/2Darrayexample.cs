using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1._2DA
{
    class _2Darrayexample
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            Console.WriteLine($"Length={arr.Length}");
            int[,] arr2d = new int[3, 4];



            Console.WriteLine($"Length of 2d array={arr2d.Length}");
            Console.WriteLine("rows " + arr2d.GetLength(0));
            Console.WriteLine("cols " + arr2d.GetLength(1));

            for (int r = 0; r < arr2d.GetLength(0); r++)
            {
                Console.WriteLine("enter elements for row " + r);

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

            //2X3
            float[,] a2 = { {2.3f,4.5f,7.8f},
                            {3.3f,5.5f,6.8f}
            };

        }
    }
}
