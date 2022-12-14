using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Mcq
{
    class PrimeNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number");
            int num = int.Parse(Console.ReadLine());
            int count = 0;
            for(int i = 0; i <= num; i++)
            {
                if (num % i == 0)
                {
                    count++;

                
                }
            }
        }
    }
}
