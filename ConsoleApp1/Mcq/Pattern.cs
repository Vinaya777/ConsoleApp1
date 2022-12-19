using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Mcq
{
    class Pattern
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 5; i++)
            {
                for(int j = 1; j <= 5; j++)
                {
                    if (j == i || j == 5 || i == j)
                        Console.WriteLine("*");
                    else
                        Console.WriteLine();
                }
                Console.ReadLine();
            }
        }
    }
}


