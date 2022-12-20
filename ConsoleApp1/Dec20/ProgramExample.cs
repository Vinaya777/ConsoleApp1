using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Dec20
{
    class ProgramExample
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];

            Console.WriteLine($"Enter {arr.Length} elements ");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            // int[] arr = { 11, 12,13, 14, 15 };
            /*for(int i=0;i<arr.Length;i++)
           Console.WriteLine(arr[i]);


            foreach(int data in arr)
               Console.WriteLine(data);
*/

            for (int i = arr.Length - 1; i >= 0; i--)
                Console.WriteLine(arr[i]);


            char[] arr2 = new char[10];
            char[] arr3 = { 'a', 'b', 'c', 'e' };
            char[] arr4 = new char[] { 'e', 's', 'h', 'a', 'n' };

            string[] names = new string[5];
            Console.WriteLine("enter 5 names");

            for (int i = 0; i < names.Length; i++)
            {
                names[i] = Console.ReadLine();
            }
            foreach (string s in names)
                Console.WriteLine(s);



        }
    }
  }
