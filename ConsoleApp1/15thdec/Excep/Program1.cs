using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1._15thdec.Excep
{
    class Program1
    {
        static void Test()
        {
            int a = 4, b = 0;
            if (b == 0)
            {
                throw new DivideByZeroException("Could not continue due to zero value");
            }
            int c = a / b;
            Console.WriteLine(c);

        }
        static void Main(string[] args)
        {

            try
            {
                Test();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            finally
            {
                Console.WriteLine("End of code");
            }
        }



    }
}
