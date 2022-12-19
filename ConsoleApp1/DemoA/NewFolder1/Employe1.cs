using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DemoA.NewFolder1
{
    class Employe1
    {
        static void Main(string[] args)
        {
            List<int> a1 = new List<int>();
            a1.Add(10);
            a1.Add(40);
            a1.Add(70);
            a1.Count();
            a1.Insert(1,20);
            a1.Add(40);
            a1[0] = 100;
            a1.Add(600);
            // a1.Remove(10);
            foreach (var data in a1)
            {
                Console.WriteLine(data);
            }
            Console.ReadLine();
            Console.WriteLine(a1.Contains(600));
            Console.WriteLine(a1.Count);
            Console.ReadLine();
            foreach(var data in a1)
            {
                Console.WriteLine(data);
            }
            a1.Reverse();
            a1.Sort();
            foreach (var data in a1)
            {
                Console.WriteLine(data);
            }
            Console.ReadLine();
        }
        

      
    }
    class Emp:IComparable<Emp>
    {
        int empId;
        string empName;
        float empSalary;

        public Emp(int empId, string empName, float empSalary)
        {
            this.EmpId = empId;
            this.EmpName = empName;
            this.EmpSalary = empSalary;
        }

        public int EmpId { get => empId; set => empId = value; }
        public string EmpName { get => empName; set => empName = value; }
        public float EmpSalary { get => empSalary; set => empSalary = value; }

        public override string ToString()
        {
            return $"EmpID {empId},EmpName{empName},EmpSalary{empSalary}";
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Geeta".CompareTo("Manjiri"));
            List<Emp> slistemp = new List<Emp>();
            slistemp.Add(new Emp(1, "Vinaya", 5000f));
            slistemp.Add(new Emp(2, "vini", 8000f));
            slistemp.Add(new Emp(1, "Manisha", 4000f));
            slistemp.Add(new Emp(1, "Rajvi", 9000f));
            slistemp.Add(new Emp(1, "Geeta", 10000f));
            slistemp.Add(new Emp(1, "Babitaa", 3000f));
            slistemp.Add(new Emp(1, "Manjiri", 2000f));

            foreach(var employe in slistemp)
            {
                Console.WriteLine(employe);
            }Console.WriteLine();
            slistemp.Reverse();
            slistemp.Sort();
            foreach(var emp in slistemp)
            {
                Console.WriteLine(emp);

            }Console.ReadLine();
        }

        public int CompareTo(Emp other)
        {
            //throw new NotImplementedException();

            Console.WriteLine("in compare method");
            Console.WriteLine("this ---->" + this);
            Console.WriteLine("other----->" + other);
            if (this.empSalary < other.empSalary)
                return -1;
            else if (this.empSalary > other.empSalary)
                return 1;
            else
                return 0;
        }
    }
   


   
    
}
