using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Mcq
{
    class Emp
    {
        int id;
        string name;
        static int count;

        public Emp(string name,int id)
        {
            count++;
           this.id = count;
            this.name = name;

        }
        static void Main(string[] args)
        {
            Emp e1 = new Emp("ABC", 2);
        }
    }
}
