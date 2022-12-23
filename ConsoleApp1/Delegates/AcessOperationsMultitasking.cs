using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Delegates
{
    public delegate int actionOp(int n1, int n2);
    public delegate int actionOp1(int n1, int n2, int n3);
    public delegate int actionOp2(int n1, int n2, int n3, int n4, int n5);
    public delegate string wordOp3(string sname);
    public class AcessOperationsMultitasking
    {
        public int add(int n1, int n2)
        {
            return n1 + n2;
        }
        public int mul(int n1, int n2, int n3)
        {
            return n1 * n2 * n3;

        }
        public int substract(int n1, int n2)
        {
            return n1 - n2  ;
        }
        public string word(string sname)
        {
            return sname.ToUpper();

        }
        
        public class AccessOperation
        {
            static void Main(string[] args)
            {
                AcessOperationsMultitasking accessoperat = new AcessOperationsMultitasking();
                actionOp acOp = new actionOp(accessoperat.add);

                actionOp1 acOp1 = new actionOp1(accessoperat.mul);
                // actionOp2 acOp2 = new actionOp2(accessoperat.substract);

                acOp += new actionOp(accessoperat.add);
                acOp1 += new actionOp1(accessoperat.mul);

                int sum1 = acOp.Invoke(52, 85);
                int sum2 = acOp1.Invoke(45, 85,52);

                /*Console.WriteLine(sum1);
                Console.WriteLine(sum2);
                Console.ReadLine();
               */
                Delegate[] list = acOp.GetInvocationList();
                foreach(Delegate iteam in list)
                {
                    Console.WriteLine(iteam.Method);
                    Console.WriteLine(iteam.DynamicInvoke(65, 85));
                }
                
            }
        }

    }
}
