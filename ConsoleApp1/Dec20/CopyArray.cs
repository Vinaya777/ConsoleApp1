using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Dec20

{
    class CopyArray
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of array: ");
            int size = int.Parse(Console.ReadLine());
            int[] a = new int[size];
            int[] b = new int[size];
            Console.WriteLine("Element in Array:");
            for(int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
                b[i] = a[i];

            }
            Console.WriteLine("New Array is........");
            for(int i = 0; i < b.Length; i++)
            {
                Console.WriteLine(b[i]+" ");
                Console.ReadLine();

            }
        }
    }
}
