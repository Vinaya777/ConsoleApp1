using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Dec20
{
    class JaggedA
    {
        static void Main(string[] args)
        {
            //jagged array where no of cols in each row are different
            int[][] jarray = new int[3][];
            jarray[0] = new int[3];
            jarray[1] = new int[2];
            jarray[2] = new int[5];

            for (int r = 0; r < jarray.GetLength(0); r++)
            {
                Console.WriteLine($"Enter {jarray[r].Length} elements for row {r}");
                for (int c = 0; c < jarray[r].Length; c++)
                {
                    jarray[r][c] = int.Parse(Console.ReadLine());


                }

            }

            for (int r = 0; r < jarray.GetLength(0); r++)
            {

                for (int c = 0; c < jarray[r].Length; c++)
                {
                    Console.Write(jarray[r][c] + " ");
                }
                Console.WriteLine();

            }
        }
    }
}
