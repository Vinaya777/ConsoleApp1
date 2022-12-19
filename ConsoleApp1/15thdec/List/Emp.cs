using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1._15thdec.List
{
    class sortByempId : IComparer<Emp>
    {
        public int Compare(Emp x, Emp y)
        {
            //  throw new NotImplementedException();
            //  

            Console.WriteLine("***************Compare*********************");
            return x.EmpId - y.EmpId;
        }
    }
    class sortByempSalary : IComparer<Emp>
    {
        public int Compare(Emp x, Emp y)
        {
            //throw new NotImplementedException();
            // return x.EmpSalary - y.EmpSalary;
            return 0;
        }
    }

    class Emp : IComparable<Emp>
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
            slistemp.Add(new Emp(3, "Manisha", 4000f));
            slistemp.Add(new Emp(4, "Rajvi", 9000f));
            slistemp.Add(new Emp(5, "Geeta", 10000f));
            slistemp.Add(new Emp(6, "Babitaa", 3000f));
            slistemp.Add(new Emp(7, "Manjiri", 2000f));

            foreach (var employe in slistemp)
            {
                Console.WriteLine(employe);
            }
            Console.WriteLine();
            slistemp.Reverse();
            slistemp.Sort();
            foreach (var emp in slistemp)
            {
                Console.WriteLine(emp);

            }
            Console.ReadLine();
            //slistemp.Sort();
            slistemp.Sort(new sortByempId());
        }
       
        public int CompareTo(Emp other)
        {
            //throw new NotImplementedException();
            Console.WriteLine("****************************************CompareMethodTo**************");
            Console.WriteLine("in compare method");
            Console.WriteLine("this ---->" + this);
            Console.WriteLine("other----->" + other);
            if (this.empSalary < other.empSalary)
                return 1;
            else if (this.empSalary > other.empSalary)
                return -1;
            else
                return 0;

            return this.empId - other.empId;
            return 0;
            return this.empName.CompareTo(other.empName);
        }
    }





}
//IComparable orginal class and single sort logic
//IComparer 

