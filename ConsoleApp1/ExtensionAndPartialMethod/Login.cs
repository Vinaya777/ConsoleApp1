using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ExtensionAndPartialMethod
{


    class Login
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            arr[0] = 20;
            arr[1] = 35;
            arr[2] = 55;
            arr[3] = 70;
            arr[4] = 90;
            var res = arr.AsEnumerable();
            foreach (var val in res)
            {
                Console.WriteLine(val);
            }
        }
    }
}
