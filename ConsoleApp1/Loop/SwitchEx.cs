using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Loop
{
    public class SwitchEx
    {
        class Check
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Number :");
                int num = Convert.ToInt32(Console.ReadLine());
                switch (num)
                {
                    case 1: Console.WriteLine("It is in 1st case");break;

                    case 2: Console.WriteLine("It is in second case"); break;

                    case 3: Console.WriteLine("It is in 3rd case");break;

                    default: Console.WriteLine("Not in 1st,2nd,3rd case");break;
                        
                }
                Console.ReadLine();
            }
        }
    }
}
