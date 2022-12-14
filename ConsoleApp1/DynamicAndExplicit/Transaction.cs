using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DynamicAndExplicit
{


    public interface ICustomer1
    {
        string Details();
    }
    public interface IOrder1
    {
        string Details();
    }

    class Transaction1 : ICustomer1, IOrder1

    {
        string ICustomer1.Details()
        {
            return "Customer details";
        }
        string IOrder1.Details()
        {
            return "Order details";
        }
        static void Main(string[] args)
        {
            ICustomer1 c = new Transaction1();
            Console.WriteLine(c.Details());

            IOrder1 o = new Transaction1();
            Console.WriteLine(o.Details());
            Console.ReadLine();

        }


    }
}
