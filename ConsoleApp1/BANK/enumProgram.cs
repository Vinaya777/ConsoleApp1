using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.BANK
{
    class enumProgram
    {

        enum Bankdays { MONDAY=1,TUESDAY=2,WEDNESDAY=3,THURSDAY=4,FRIDAY=5, OFFONSATURDAY=0 ,OFFONSUNDAY=0 };

        public void showActiveDays()
        {
            Console.WriteLine("\n Monday= {0}", 1);
            Console.WriteLine("\n Tuesday= {0}", 2);
            Console.WriteLine("\n Wednesday= {0}", 3);
            Console.WriteLine("\n Thursday= {0}", 4);
            Console.WriteLine("\n Friday ={0}",5);
            Console.WriteLine("\n Saturday= {0}", 0);
            Console.WriteLine("\n Sunday= {0}", 0);

        }
    }
    
}
