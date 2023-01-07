using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DemoA.NewFolder1
{
    class DiffColArrayJD
    {
        static void Main(string[] args)
        {
            //jagged array where no of cols in each row are different
            int[][] jarr = new int[3][];
            jarr[0] = new int[3];
            jarr[1] = new int[2];
            jarr[2] = new int[5];

            for (int r = 0; r < jarr.GetLength(0); r++)
            {
                Console.WriteLine($"Enter {jarr[r].Length} elements for row {r}");
                for (int c = 0; c < jarr[r].Length; c++)
                {
                    jarr[r][c] = int.Parse(Console.ReadLine());


                }

            }

            for (int r = 0; r < jarr.GetLength(0); r++)
            {

                for (int c = 0; c < jarr[r].Length; c++)
                {
                    Console.Write(jarr[r][c] + " ");
                }
                Console.WriteLine();

            }
        }
    }
}
