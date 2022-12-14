using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class SumOfDigitcs
    {
        static void Main(string[] args)
        {
           
            {

                int[] arr = new int[] { 1, 2, 3, 4, 5 };
                int sum = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    sum = sum + arr[i];
                }
                Console.WriteLine("Sum of all the elements of an array: " + sum);
                Console.ReadLine();
            }
        }
    }
 }
