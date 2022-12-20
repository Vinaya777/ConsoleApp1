using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DemoA
{
    class CommonEltBetweenTwoArray
    {

        public void CommonElement(int []x, int [] y)
        {
            Console.WriteLine("Common element................................................");
            foreach (var arr in x)
            {
                int flag = 0;
                
               foreach(var arr1 in y)
                {
                    if (x == y)
                    {
                        flag = 1;
                        
                    }
                }
                if (flag == 1)
                    Console.WriteLine(x + " " + y);
                Console.ReadLine();
            }
            
        }
        static void Main(string[] args)
        {
            int[] arr = { 12, 14, 16, 18, 20 ,32};
            int[] arr1 = { 14, 21, 18, 20, 25, 38 };

            CommonEltBetweenTwoArray ce = new CommonEltBetweenTwoArray();
            
            ce.CommonElement(arr,arr1);

            Console.ReadLine();
        }
    }
}
