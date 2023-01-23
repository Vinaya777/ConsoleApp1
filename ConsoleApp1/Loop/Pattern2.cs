using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Loop
{
    public class Pattern2
    {
        static void Main(string[] args)
        {
            int i, j, k;
            int n = 6;
            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");

                }
                for (k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");


            }
            Console.ReadLine();
        }

    }
}
