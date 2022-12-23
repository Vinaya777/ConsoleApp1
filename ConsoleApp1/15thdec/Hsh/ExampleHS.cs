using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1._15thdec.Hsh
{
    class ExampleHS {
        static void Main(string[] args)
        {
            HashSet<string> hashset = new HashSet<string>();
            hashset.Add("Sunday");
            hashset.Add("Monday");
            hashset.Add("Tuesday");
            hashset.Add("Wednesday");
            hashset.Add("Thursday");
            hashset.Add("Firday");
            hashset.Add("Saturday");

            if (hashset.Contains("Saturday"))
                hashset.Remove("Saturday");

            if (hashset.Contains("Monday"))
                hashset.Remove("Monday");

            Console.WriteLine(hashset);
            Console.ReadLine();
        }
    }
}
