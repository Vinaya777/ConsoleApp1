using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1._2DA
{
    class MinInEachRow
    {
        public void acceptArrayVal(int[,] x)
        {
            Console.WriteLine("Enter the array Values:");
            for (int i = 0; i < x.Length; i++)
            {
                for (int j = 0; j < x.Length; i++)
                {
                    x[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
        public void MinInEachRowis(int[,] x)
        {
            for (int i = 0; i < x.Length; i++)
            {
                int min = x[i, 0];
                for (int j = 0; j < x.Length; j++)
                {
                    if (min > x[i, j])
                        min = x[i, j];
                }
                Console.WriteLine("Minimum element in row" + (i + 1) + "is" + min);


            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number of row");
            int row = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Number of coloum ");
            int coloum = int.Parse(Console.ReadLine());
            int[,] a = new int[4, 4];
            MinInEachRow minr = new MinInEachRow();
            minr.acceptArrayVal(a);
            minr.MinInEachRowis(a);
        }
    }
}
