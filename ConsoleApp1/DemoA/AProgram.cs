using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DemoA
{
    class AProgram
    {
        public void fun(int[] a1,int[] a2)
        {
            int n = a1.Length;
            int m = a2.Length;
            int[] ans = new int[n + m];
            int i = 0, j = 0, k = 0;

            while(i<n && j < m)
            {
                ans[k++] = a1[i++];
                ans[k++] = a2[j++];

            }
            while (i < n)
            {
                ans[k++] = a1[i++];
            }
            while (i < n)
            {
                ans[k++] = a1[i++];

            }
            while(j  < m)
            {
                ans[k++] = a2[i++];

            }
            Console.WriteLine(string.Join(" ", ans));
        }
        
        static void Main(string[] args)
        {
            AProgram ap = new AProgram();
           
           
        }
    }
}
