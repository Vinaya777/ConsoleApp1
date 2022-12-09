using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ObjectAndClasses
{
    class Sample
    {
        static void Main(string[] args)
        {
            Employe emp = new Employe(101, "Emp1", 23000.55);
            emp.CalculateSalary();
            string data=emp.Print();
            Console.WriteLine(data);
           // or
            Console.WriteLine(emp);

        }
    }
}
