using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Loop
{
    class TableOfGivenNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                /*if (i == 5)
                    continue;
                if (i == 8)
                    break;*/
                Console.WriteLine(num * i);



            }
        }
    }
}