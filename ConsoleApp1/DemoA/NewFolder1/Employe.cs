using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DemoA.NewFolder1
{
    public partial class Employe
    {
        public int empId;
        public string nameEmp;

        public Employe(int id,string name)
        {
            this.empId = id;
            this.nameEmp = name;

        }
        public void DisplayEmpInfo()
        {
            Console.WriteLine(this.empId+" "+this.nameEmp);
        }

        public override string ToString()
        {
            return $"";
        }
        static void Main(string[] args)
        {
            Employe emp = new Employe(25, "CDS");
            Console.WriteLine(emp.empId);
            Console.WriteLine(emp.nameEmp);
            Console.ReadLine();

        }
    }   
}
