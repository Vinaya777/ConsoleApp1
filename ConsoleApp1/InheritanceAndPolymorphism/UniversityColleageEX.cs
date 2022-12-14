using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.InheritanceAndPolymorphism
{
    class UniversityColleageEX
    {

        static void Main(string[] args)
        {
            University un = new University("IT","Manisha");
            un.ShowUniversityDetails();
            
             
            Console.WriteLine(un);
            Console.ReadLine();
            
        }

    }
}
