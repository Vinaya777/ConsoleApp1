using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Loop
{
    class PrimeNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("number");
            int num = int.Parse(Console.ReadLine());
            bool isPrime = true;
            int count = 0;
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    count++;
                    isPrime = false;
                    break;
                }
            }
            if (isPrime == true)
            {
                Console.WriteLine("Primee");
            }
            else
            {
                Console.WriteLine("Not Prime");
            }
        }
    }
}
