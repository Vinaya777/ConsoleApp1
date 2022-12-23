using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Delegates
{
    public delegate int myOp1(int n1, int n2);
    public delegate string myOp2(string s);
   public class Operation
    {

        public int Mul(int n1,int n2)
        {
            return n1 * n2;
        }
        public string display(string name)
        {
            return name.ToUpper();

        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Operation op = new Operation();
            myOp1 op1 = new myOp1(op.Mul);
            int sum = op1.Invoke(56, 2);
            Console.WriteLine(sum);
            myOp2 op2 = new myOp2(op.display);
            string s = op2.Invoke("WE ARE CODING");
            Console.WriteLine(s);
            Console.ReadLine();
            
        }
    }


}
