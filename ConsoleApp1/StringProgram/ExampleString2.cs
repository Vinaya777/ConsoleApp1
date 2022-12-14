using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.StringProgram
{
    class ExampleString2
    {
        static void Main(string[] args)
        {
            string str1 = "test";
            string str2 = str1;
            char[] ch = { 't', 'e', 's', 't' };

            //  string str3 = new string(ch);
            object str3 = new String(ch);
            Console.WriteLine(str3);
            bool res = str1.Equals(str3);// focus on content
            Console.WriteLine(res);

            if (str1 == str2) // focus on data type
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }

    }

}
