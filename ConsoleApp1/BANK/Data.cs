using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace ConsoleApp1.BANK
{
    struct Data
    {
        private void start()
        {
            Console.WriteLine("\n\n \t Bank Application System ");
            
        }
        public void showStart()
        {
            start();

        }
         internal void accessDetails()
        {
            Console.WriteLine("Wait For A Movement Your Account is Processing....!!!!!!");
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine(" . ");

                Thread.Sleep(550);
            }
        }
    }
}
