using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DemoA.NewFolder1
{
    class NoDivisibleBy3
    {
        public void acceptArrayValues(int[] x)
        {
            Console.WriteLine("Enter the Value");
            for(int i = 0; i < x.Length; i++)
            {
                x[i] = int.Parse(Console.ReadLine());
            }

        }

        public void displayNoDivisibleBy3(int[] x)
        {
            Console.WriteLine("Number divisible by 3");
            for(int i = 0; i < x.Length; i++)
            {
                if (x[i] % 3 == 0)
                {
                    Console.WriteLine(x[i] + "");
                }
            }Console.ReadLine();

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Size Of Array");
            int size = int.Parse(Console.ReadLine());
            int[] a = new int[size];

            NoDivisibleBy3 num3 = new NoDivisibleBy3();
            num3.acceptArrayValues(a);
            num3.displayNoDivisibleBy3(a);


        }
    }
}
