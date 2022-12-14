using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.StringProgram
{
    class ProgramEquals
    {
        static void Main(string[] args)
        {
            string str = "hey";
            string str1 = str;
            Console.WriteLine("Using = operator "+str==str1);
            Console.WriteLine("Using equals()"+(str.Equals(str1)));
            Console.ReadLine();
        }
    }
}
