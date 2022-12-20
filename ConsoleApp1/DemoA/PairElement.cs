using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DemoA
{
    class PairElement
    {

        public void Pair(int[] a)
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            for(int i = 0; i < a.Length; i++)
            {
                for(int j = 0; j < a.Length; i++)
                {
                    if (num == a[i] + a[j])
                    {
                        Console.WriteLine($"({a[i]},{a[j]})");
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int[] arr = { 4, 5, 7, 1, 2, 3, 0 };
            PairElement pe = new PairElement();
            pe.Pair(arr);

            
        }
    }
}
