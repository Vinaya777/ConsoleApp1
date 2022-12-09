using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ConstructorAndMethod
{
    class Employe
    {
        private int empid;
        private string empname;
        private float empbalance;
        private static int count;
        

        public Employe(int empid,string empname,float empbalance,int count,string empstatus="excellent employe")
        {
            count++;
            empid = count;
            this.empname = empname;
            this.empbalance = empbalance;
           
        }
        public static int GetCount()
        {
            return count;
        }

        public override string ToString()
        {
            return $"{empname}-->{empid}-->{empbalance}--->{count}";
        }
    }
}
