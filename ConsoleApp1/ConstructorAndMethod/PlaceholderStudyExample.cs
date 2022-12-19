using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ConstructorAndMethod
{
    class PlaceholderStudyExample
    {
        static void Main(string[] args)
        {
            int year = 2022;
            string name = "Think Quotient";
            // 1 .  + 
            Console.WriteLine("Company name is " + name + " Year " + year);

            // place holder
            Console.WriteLine("Company name is {0} and year {1}", name, year);

            // $  -- >string interpolation
            Console.WriteLine($"company name is {name} and year {year}");
            Console.ReadLine();
        }
    }
}
