using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Delegates
{
    public class Calculate1
    {
       public static void Calculate(int a, int b, out int sum)
        {
            sum = a + b;

        }
    }
    public class Variables
    {
       
        static void Main(string[] args)
        {
            int a = 44, b = 22,sum;
            Variables var = new Variables();
            Calculate1.Calculate(a, b, out sum);
            Console.WriteLine();
            
            

        }
    }
}
