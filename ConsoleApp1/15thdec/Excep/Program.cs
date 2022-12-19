using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1._15thdec.Excep
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 4, b = 0;
            try
            {
                int[] arr = new int[5];
                arr[3] = 100;
                int c = a / b;
                Console.WriteLine(c);
            }
            // Exception base class will handle all type of exception
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("End of code");
            }
            Console.ReadLine();

        }
    }
}
