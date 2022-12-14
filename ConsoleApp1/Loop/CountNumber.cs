using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Loop
{
    class CountNumber
    {
        /*static void Main(string[] args)
        {
            int num = 123456789;
            string value = num.ToString();
            Console.WriteLine(value);
            Console.ReadLine();
        }*/
    }

    class OtherMethod
    {
        static void Main(string[] args)
        {

            Console.Write("\n\n Recursion : Count the number of digits in a number :\n");
            Console.Write("---------------------------------------------------------\n");
            Console.Write(" Input any number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n The number {0} contains number of digits : {1} ", num, getDigits(num, 0));
            Console.ReadLine();
        }

        public static int getDigits(int n1, int nodigits)
        {
            if (n1 == 0)
                return nodigits;

            return getDigits(n1 / 10, ++nodigits);
        }
    }


    class SumCount
    {
        static void Main(string[] args)
        {
            int n, sum = 0, m;
            Console.Write("Enter a number: ");
            n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                m = n % 10;
                sum = sum + m;
                n = n / 10;
            }
            Console.Write("Sum is= " + sum);
        }
    }
    
} 
