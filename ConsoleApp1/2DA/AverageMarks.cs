using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1._2DArray
{
    class AverageMarks
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of subjects: ");
            int sub = int.Parse(Console.ReadLine());
            int[] a = new int[sub];
            Console.WriteLine("enter" + sub + "subject marks");
            for(int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("Entered Marks Average: ");
            int sum = 0;
            for(int i = 0; i < sub; i++)
            {
                sum = sum + a[i];

            }
            int avg = sum / sub;
            Console.WriteLine("Average" + avg);
            Console.ReadLine();
        }
    }
}
