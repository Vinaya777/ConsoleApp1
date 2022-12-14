using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.StringProgram
{
    class ExampleString
    {
        static void Main(string[] args)
        {
            string str1 = "Hello to all";
            Console.WriteLine(str1.Length);
            string str2 = "welcome to C#";
            //str1.Concat(str2);
            string str = String.Concat(str1, str2);
            Console.WriteLine(str);
            Console.WriteLine(str2);
            bool result = str1.StartsWith("Hello");
            Console.WriteLine(result);
            bool res = str1.EndsWith("everyone");

            bool r = str1.Contains("to");
            Console.WriteLine(r);
            Console.WriteLine(str1.ToUpper());
            Console.WriteLine(str1.ToLower());

            char[] ch = str1.ToCharArray();
            foreach (var item in ch)
            {
                Console.WriteLine(item);
            }
            str1.Trim();

        }
    }
}
