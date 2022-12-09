using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ConstructorAndMethod
{
    class Access
    {
        static void Main(string[] args)
        {
            EmployeeAccount ac = new EmployeeAccount(121, "XYZ", 550000);
            ac.CalculateSalary();
            Console.WriteLine(ac);
            Manager mg = new Manager(250,"ABC",2525555.36,1500);
            mg.CalculateSalary();
            Console.WriteLine(mg);
            SalesManager sm = new SalesManager(240, "FREe", 50000, 80000,65,85);
           
            sm.CalculateSalary();
            Console.WriteLine(sm);


            Console.ReadLine();
                
        }
    }
}
