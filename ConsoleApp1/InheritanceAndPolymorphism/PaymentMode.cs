using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.InheritanceAndPolymorphism
{
    class PaymentMode
    {
        static void Main(string[] args)
        {
            ApplicationPayroll ap = new ApplicationPayroll(250000, 5000, 800);
            ap.Salary();
            Console.WriteLine(ap);
            OnlinePayroll op = new OnlinePayroll(20000, 560000, 50000, 4000,40);
            op.SalaryOnline();
            Console.WriteLine(op);
            PayrollAccounting pa = new PayrollAccounting(25000, 50000, 200000, 30000, 400000, 7000);
            Console.WriteLine(pa);
            Console.ReadLine();
        }
    }
}
