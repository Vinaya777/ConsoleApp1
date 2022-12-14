using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Loop
{
    class UsingWhileloop1to20
    {
        static void Main(string[] args)
        {
            int num, sum = 0, i = 1;
            Console.WriteLine("Value Of Number");
            num = int.Parse(Console.ReadLine());

            while (i <= num)
            {
                sum = num + i;
                num = i + 2;
            }
            Console.WriteLine(sum);
            Console.ReadLine();

        }
    }
}
