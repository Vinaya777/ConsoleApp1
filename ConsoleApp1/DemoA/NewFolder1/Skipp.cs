using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DemoA.NewFolder1
{
   public class Skipp
    {

        public int[] Mysort(int[] a)
        {
            for (int i = 2; i < a.Length; i++)
            {
                for (int j =  + 1; j < a.Length; j++)
                {
                    if (a[i] < a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
            return a;

            Array.Sort<int>(a, 2, 3);
             Console.WriteLine(string.Join(" ", a));
        }
      
        public class Sort
        {

            
            static void Main(string[] args)
            {
                int[] arr = { 8, 3, 8, 9, 4, 7 };
                Console.WriteLine(string.Join(" ", arr));
                Skipp s = new Skipp();
                Console.WriteLine("................................" + string.Join(" ", s.Mysort(arr)));
            }
        }
    }
}
