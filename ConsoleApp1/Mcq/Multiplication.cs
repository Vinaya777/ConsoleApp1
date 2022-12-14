using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Mcq
{
    class Multiplication
    {

        static  void   Mul(int x, ref int ss, ref int cc)
        {
            ss = x * x;
            cc = x * x * x;
        }
        static void Main(string[] args)
        {
            int a = 5;
            int s = 0, c = 0;
            Mul(a, ref s, ref c);
            Console.WriteLine(s+"t "+c);
            Console.ReadLine();
            
        }
    }
}
