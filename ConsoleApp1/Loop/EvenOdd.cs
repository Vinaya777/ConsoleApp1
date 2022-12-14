using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Loop
{
    class EvenOdd
    {
        
        
        public EvenOdd(int num)
        {
            
            if (num % 2 == 0)
            {
                Console.WriteLine("Even");

            }
            else
            {
                Console.WriteLine("Odd");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number:");
            int num = int.Parse(Console.ReadLine());
            EvenOdd eo = new EvenOdd(num);
           

        }
    }
}
