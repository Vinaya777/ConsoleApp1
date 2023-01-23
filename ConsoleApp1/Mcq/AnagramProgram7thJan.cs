using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Mcq
{
    class AnagramProgram7thJan
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the string");
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            char[] ch1 = str1.ToLower().ToCharArray();
            char[] ch2 = str2.ToLower().ToCharArray();
            Array.Sort(ch1);
            Array.Sort(ch2);
            string val1 = new string(ch1);
            string val2 = new string(ch2);
            if (val1 == val2)
            {
                Console.WriteLine(val1);
            }
            else
            {
                Console.WriteLine(val2);
            }
            Console.ReadLine();
        }
    }
}
