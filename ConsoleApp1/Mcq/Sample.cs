using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Mcq
{
    class Sample
    {
        public int func(int num1)
        {
            return (num1 > 0 ? num1 : num1 * -1);

        }

        public long func(long num2)
        {
            return (num2 > 0 ? num2 : num2 * -1);
        }

        public double func(double num3)
        {
            return (num3 > 0 ? num3 : num3 * -1);
        }

        static void Main(string[] args)
        {
            Sample s = new Sample();
            int i = -25;
            int j;
            long l = -10001;
            long m;
            double d = -12.34;
            double e;
            j = s.func(i);
            m = s.func(l);
            e = s.func(d);
            Console.WriteLine(j+" "+m+" "+e);
            Console.ReadLine();

        }
    }
}
