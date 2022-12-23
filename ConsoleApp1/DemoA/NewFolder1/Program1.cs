using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DemoA.NewFolder1
{
    class Program1
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            for (int i = 0, j = arr.Length / 2; i < arr.Length / 2 && j < arr.Length; i++, j++)
            {
                int temp;
                temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }

            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }

        }
    }
/// <summary>
/// ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/// </summary>
    class Copy
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 1, 2, 3, 6, 8, 2 };
            int[] arr2 = new int[] { 6, 7, 8, 9, 10, 9 };
            List<int> list = new List<int>();

            for (int i = 0; i < arr1.Length; i++)
            {
                if (!list.Contains(arr1[i]))
                    list.Add(arr1[i]);
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                if (!list.Contains(arr2[i]))
                {
                    list.Add(arr2[i]);
                }
            }
            list.Sort();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

        }

    }
}


