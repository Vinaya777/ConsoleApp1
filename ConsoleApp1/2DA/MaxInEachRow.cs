using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1._2DA
{
    class MaxInEachRow
    {

        public void acceptArrayValue(int [,] x)
        {
            Console.WriteLine("Enter the array value: ");
            for(int i = 0; i < x.Length; i++)
            {
                for(int j = 0; j < x.Length; i++)
                {
                    x[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        public void maxInEachRow(int [,] x)
        {
            for (int i = 0; i < x.Length; i++)
            {
                int max = x[i,0];
                for (int j = 0; j < x.Length; j++)
                {
                    if (max < x[i,j])
                        max = x[i,j];
                }
                Console.WriteLine("Maximum element in row" + (i + 1)+" is "+ max );
            }
        }

                static void Main(string[] args)
        {
            Console.WriteLine("Enter the row ");
            int a1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the coloum");
            int b1 = int.Parse(Console.ReadLine());
            int[,] x = new int[3, 4];
            MaxInEachRow mer = new MaxInEachRow();
            


        }

    }
}
