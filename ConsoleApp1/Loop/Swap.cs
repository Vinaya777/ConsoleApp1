using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Loop
{
    class Swap
    {
        static void Main(string[] args)
        {
            int first, second;
            first = 1;
            second = 2;
            first = first + second;
            second = first - second;
            first = first - second;
            Console.WriteLine(first.ToString());
            Console.WriteLine(second.ToString());
            Console.ReadLine();
        }
    }
}
