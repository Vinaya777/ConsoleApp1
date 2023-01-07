using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DemoA.NewFolder1
{
    class ADTNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int n = Convert.ToInt32(Console.ReadLine());
            int inc = 0, dec = 0, bouncy = 0, count = 0;
            int temp = n % 10;
            int x = n;
            while (x > 0)
            {
                x /= 10;
                count++;

            }
            while (n > 0)
            {
                n /= 10;
                if (temp > (n % 10))
                {
                    inc++;
                }else if (temp < (n % 10))
                {
                    dec++;

                }
                else
                {
                    bouncy++;

                }
                temp = (n % 10);
            }
            if (inc == count)
            {
                Console.WriteLine("Increasing number");

            }else if (dec == (count - 1))
            {
                Console.WriteLine("Decreasing number");

            }
            else
            {
                Console.WriteLine("Bouncy");
            }
            Console.ReadLine();
        }
    }
}
