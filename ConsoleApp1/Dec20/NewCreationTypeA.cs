using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Dec20
{
    class NewCreationTypeA
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 45, 55, 65, 95, 85, 75, 15, 25, 35, 45, 65 };
            int[,] arrr = new int[6, 4];
            int[,] data = new int[3, 4];

            int[] arr2 = new int[3];
            int[] arr3 = new int[5];
            Console.WriteLine("Orignal Array: ");
            foreach(var item in arr)
            {
                Console.WriteLine(item);


            }
            /*int[,] arr = new int [6,4];
            { { 2,4,6,8},{3,6,9,12 },{ 4,8,12,16},{5,10,15,20 },{6,12,18,24 },{7,14,21,28,35 } };*/
            int[,] data2 = new int[4, 6]
           {
                { 1,2,3,4,5,6},
                {1,2,3,4,5,6 },
                {1,2,3,4,5,6 },
                { 1,2,3,4,5,6}
           };
            for (int i = 0; i < data.GetLength(0); i++)   // 0--> row size
            {
                for (int j = 0; j < data.GetLength(1); j++) // 1 --> col size
                {
                    Console.Write($"data=[{i},{j}] = {data[i, j]}  ");

                }
                Console.WriteLine();
            }
            foreach (int item in data)
            {
                Console.WriteLine(item);
            }




        }
    }
}
