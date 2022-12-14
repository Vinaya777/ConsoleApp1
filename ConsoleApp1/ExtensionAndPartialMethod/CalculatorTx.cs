using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ExtensionAndPartialMethod
{
    class CalculatorTx
    {
        static void Main(string[] args)
        {
            Calculation c = new Calculation();
            c.Add(5, 8);
            c.Sub(8, 6);
            
            c.HelperMethod(5);
        }

    }
}
