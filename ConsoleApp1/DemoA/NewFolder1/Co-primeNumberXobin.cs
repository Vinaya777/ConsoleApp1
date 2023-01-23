using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DemoA.NewFolder1
{
    class Co_primeNumberXobin
    {
        static void Main(string[] args)
        {
            int a, b, gcd = 1;

            Console.WriteLine("Enter a=");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine ("Enter b=");
            b = Convert.ToInt32(Console.ReadLine());
            int min, max;
            min = a;
            if (min > b)
            {
                min = b;
                max = a;
            }
            else
            {
                min = a;
                max = b;
            }
            while (max > min)
            {
                int r = max % min;
                if (r == 0)
                {
                    gcd = min;
                    break;
                }
                else
                {
                    max = min;
                    min = r;
                }
            }
            if (gcd == 1)
            {
                Console.WriteLine ("Co Prime Numbers");
            }
            else
            {
                Console.WriteLine ("Not Co Prime Numbers");
            }

        }
    }
}
