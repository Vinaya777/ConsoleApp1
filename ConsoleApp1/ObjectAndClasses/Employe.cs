using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ObjectAndClasses
{
    class Employe
    {
        private int empacno;
        private String  empname;
        private double basic, hra, da, pf, gross;

        public int Empacno 
        {
            get => empacno; set => empacno = value;
        }
        public string Empname 
        { 
            get => empname; 
            set => empname = value; 
        }
        public double Basic
        { 
            get => basic; 
            set => basic = value;
        }
        public double Hra
        {
            get => hra; 
            set => hra = value; 
        }
        public double Da 
        { 
            get => da;
            set => da = value;
        }
        public double Pf
        { 
            get => pf;
            set => pf = value;
        }
        public double Gross
        { 
            get => gross; 
            set => gross = value; 
        }

        public Employe(int empacno, string empname, double basic)
        {
            this.empacno = empacno;  
            this.empname = empname;
            this.basic = basic;
        }
        public void CalculateSalary()
        {
            hra = basic * 0.40;
            da = basic * 0.20;
            pf = basic * 0.12;
            gross = (basic + hra + da) - pf;
        }
       // ToString() --> string representation of an object
        public override string ToString()
        {
            return $"Employee id {empacno}, emp name {empname} & gross salary of emp {gross}";
        }

        public string Print()
        {
            return $"Employee id {empacno}, emp name {empname} & gross salary of emp {gross}";
        }

        static void Main(string[] args)
        {
           /* 
            Employe emp = new Employe(101, "Emp1", 23000.55);
            emp.CalculateSalary();
            //string data=emp.Print();
            //Console.WriteLine(data);
            // or
            Console.WriteLine(emp);
*/
        }





    }
   
}
