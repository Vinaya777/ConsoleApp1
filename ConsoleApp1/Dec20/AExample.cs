using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Dec20
{
    class AExample
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            Console.WriteLine($"enter {arr.Length} elements in array");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());


            }

            int max = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (max < arr[i])
                    max = arr[i];
            }

            Console.WriteLine("Max=" + max);

        }
    }
}
