using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Loop
{
    public class CommissionOnSale
    {

        static void Main(string[] args)
        {
            double com = 0;
            Console.WriteLine("Amount................");
            float sale = 15000f;
            Console.WriteLine(" Sale value"+sale );

            if (sale < 10000)
            {
                com = sale * 0.5;
            }
            else if (sale >= 10000 && sale < 25000)
            { com = sale * 0.15; 
            }
            else if (sale >= 25000 && sale < 5000)
            {
                com = sale * 0.25;
            }
               

            Console.WriteLine("Comission" + com);

        }
    }
}
