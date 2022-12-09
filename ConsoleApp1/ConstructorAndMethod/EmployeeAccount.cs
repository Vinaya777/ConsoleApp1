using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ConstructorAndMethod
{
   public  class EmployeeAccount
    {
        protected int empid;
        protected string empname;
        protected double empbasic;
        protected double basic, hra, da, Pf, gross;

        public EmployeeAccount(int empid, string empname, double basic)
        {

            this.empid = empid;
            this.empname = empname;
            this.basic = basic;

        }
        public virtual void CalculateSalary()
        {
            hra = basic * 0.4;
            da = basic * 0.02;
            Pf = basic * 0.12;
            gross = (basic + hra + da) - Pf;

        }
        public override string ToString()
        {
            return $"Employee id{ empid},emp name{ empname}& gross slaray of emp{gross}";

        }
    }

        public class Manager : EmployeeAccount
        {
            private double food;
            public Manager(int id, string name, double bs, double food) : base(id, name, bs)
            {
                this.food = food;
            }
            public override void CalculateSalary()
            {
                hra = basic * 0.40;
                da = basic * 0.20;
                Pf = basic * 0.12;
                gross = (basic + hra + da + food) - Pf;
            }

            public override string ToString()
            {
                return $"Employee id {empid}, emp name {empname} & gross salary of manager {gross}";
            }
        }
    public class SalesManager : EmployeeAccount
    {
        private int com;
        private int bouns;

        public SalesManager(int id, string name, double bs, double food,int bouns,int com) : base(id, name, bs)
        {
            this.bouns = bouns;
            this.com = com;

            
        }
        public override void CalculateSalary()
        {
            hra = basic * 0.40;
            da = basic * 0.20;
            Pf = basic * 0.12;
            gross = (basic + hra + da + com+bouns) - Pf;
        }

        public override string ToString()
        {
            return $"Employee id {empid}, emp name {empname}, & gross salary of manager {gross}" ;
        }
    }

}
