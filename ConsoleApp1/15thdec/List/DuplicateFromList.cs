using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1._15thdec.List
{
    class DuplicateFromList
    {
        static void Main(string[] args)
        {
            List<string> l = new List<string>();
            l.Add("1");
            l.Add("2");
            l.Add("2"); // duplicate
            l.Add("3");
            l.Add("4");
            l.Add("4"); // duplicate
            l.Add("5");

            // Make new unique list
            List<string> uniqueList = l.Distinct().ToList();

            // Write to console
            uniqueList.ForEach(i => Console.WriteLine($"{i}"));

            Console.ReadLine();

        }
    }
}
