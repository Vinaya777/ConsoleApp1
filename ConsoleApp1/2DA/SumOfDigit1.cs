using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1._2DArray
{
    class SumOfDigit1
    {
        static void Main(string[] args)
        {

            int[] arr = new int[] { 1, 2, 3, 4, 5 };
            int sum = 0;
            float average = 0.0F;
            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }
            average = (float)sum / arr.Length;
            Console.WriteLine("Sum of all the elements of an array: " + sum);
            Console.ReadLine();

        }
    }
    class String
    {
        static void Main(string[] args)
        {
            string str;
            Console.WriteLine("String");
            str = Console.ReadLine();
            int count, sum = 0; float average = 0.0F; 
            int n = str.Length;
            for(count = 0; count < n; count++)
            {
                if ((str[count] >= '0') && (str[count] <= '9'))
                {
                    count += (str[count] - '0');
                }
                Console.WriteLine("Sum "+sum);
            }
            average = (float)sum / str.Length;
        }
    }

    
}
