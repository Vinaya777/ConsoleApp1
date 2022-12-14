using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.StringBulider
{
    class Demo
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("Helooo to My Friends");
            Console.WriteLine(sb);
           /* sb.Append("Welcome to Program");
            Console.WriteLine(sb);

            // sb.Remove(0, 5);
            Console.WriteLine(sb);
            sb.Clear();

            sb.Replace("to", "All");
            Console.WriteLine(sb);*/
            double price = 450000;
            sb.AppendFormat("price is {0:C}", price);
            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
