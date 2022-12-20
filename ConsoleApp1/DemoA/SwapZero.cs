using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DemoA
{
    class SwapZero
    {

        public void AcceptArrayElets(int [] x)
        {
            Console.WriteLine("Enter the Array Elements: ");
            for(int i = 0; i < x.Length; i++)
            {
                x[i] = int.Parse(Console.ReadLine());
            }

        }
        public void endwithZero(int[] a)
        {
            for(int i=0;i<a.Length;i++)
            {
                if(a[i]% 10 == 9)
                {
                    a[i] = 0;
                }
                foreach(var b in a)
                {
                    Console.WriteLine(b);
                }
                Console.ReadLine();
            }
           
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size Array: ");
            int x = int.Parse(Console.ReadLine());
            int[] a = new int[x];
            SwapZero sz = new SwapZero();
            sz.AcceptArrayElets(a);
            sz.endwithZero(a);

        }
    }
}
