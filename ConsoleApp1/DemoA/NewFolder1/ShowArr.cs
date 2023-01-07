using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DemoA.NewFolder1
{
    class ShowArr
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            Console.WriteLine($"Enter the {arr.Length} elemenets");
            for(int i=0;i<arr.Length;i++)
            {
                arr[i] = int.Parse(Console.ReadLine());

            }
            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine(arr[i]);
            
            Console.ReadLine();
        }
    }
}
