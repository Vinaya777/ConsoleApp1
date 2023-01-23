using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*If n is odd, print Weird
If n is even and in the inclusive range of 2 to 5, print Not Weird
If n is even and in the inclusive range of 6 to 20, print Weird
If n is even and greater than 20, print Not Weird*/
namespace ConsoleApp1.Mcq
{
    public class Solution
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the string");
            int n = int.Parse(Console.ReadLine());
            string str = "";
            if (n % 2 == 1 || ((n % 2 == 0) && (n >= 6 && n <= 20)))
            {
                str = "Weird";
            }
            else
            {
                str = "Not Weird";
            }
            Console.WriteLine(str);
            Console.ReadLine();
        }
    }
}
