using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ConstructorAndMethod
{
    public class Company
    {
        private int id;//4
        private string name;//4
                            //8
        private static int count;
        private int hra, da, pf, netpaid, basicsalary;
        public Company(string name, int basicsalary)
        {
            count++;
            this.id = count;
            this.name = name;
            this.basicsalary = basicsalary;

        }
        public static string TotalCount()
        {
            return $"Total count is {count}";
        }
        public void CalculateSalary()
        {
            /*hra = basicsalary * 0.40;
            da = basicsalary * 0.20;
            pf = basicsalary * 0.12;*/
            netpaid = (hra + da + basicsalary) - pf;
        }

        public override string ToString()
        {
            return $"Id :{id} Name :{name} Salary {basicsalary}";
        }


        static void Main(string[] args)
        {
            Company c = new Company("Vinaya", 35000);
            Company c1 = new Company("Manisha", 45000);
            Company c2 = new Company("Rajvi", 50000);
            c.CalculateSalary();
            Console.WriteLine(c);
            c1.CalculateSalary();
            Console.WriteLine(c1);
            c2.CalculateSalary();
            Console.WriteLine(c2);

        }
     }

        
    
   }

