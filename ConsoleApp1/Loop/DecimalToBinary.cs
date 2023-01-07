using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Loop
{
    class DecimalToBinary
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string s = " ";
            while (n > 0)
            {
                int r = n % 2;
                s = r + s;
                n = n / 2;

            }
            Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}
