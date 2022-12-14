using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.StringProgram
{
    class ExampleString1
    {
        static void Main(string[] args)
        {
            string str1 = "Test";
            string str2 = "TEst";
            int a = String.Compare(str1, str2);
            Console.WriteLine(a);// -1  0  1

            // it will compare using ASCII value
            // a- 97 b-98 c-99 d-100 e-101   A- 65
            // e- 101                       E- 69

            //  69-101  --> - value
            string str3 = null;
            string str4 = "TEst";
             int b=String.Compare(str1, str2);
           Console.WriteLine(b);// -1  0  1

            //bool res=str1.Equals(str2);
            //Console.WriteLine(res);

            bool r1 = String.IsNullOrEmpty(str3);
            Console.WriteLine(r1);

        }
    }
}
