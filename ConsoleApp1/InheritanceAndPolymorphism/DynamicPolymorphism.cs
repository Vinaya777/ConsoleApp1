using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.InheritanceAndPolymorphism
{

    class Payment
    {
        public float Pay(int qty, float price)
        {
            return qty * price;
        }
    }
    class NetBanking: Payment
    {
        public float Pay(int qty,float price)
        {
            Console.WriteLine("Do transaction using net banking");
            return qty * price ;

        }

    }

    class DebitCard : Payment
    {
        public float Pay(int qty,float price,float tax)
        {
            Console.WriteLine("Do transaction using debit card");
            return qty * price * tax;
        }
    }
    class CreditCard : Payment
    {

    public float Pay(int qty, float price)
    {
        Console.WriteLine( "Do transaction using credit card");
        return qty *   price;
    }
}

public class DynamicPolymorphism
    {

        static void Main(string[] args)
        {
            Payment p = new Payment();
            double price = p.Pay(2, 20000f);
            Console.WriteLine("Payment of Rs: "+price);
            Console.WriteLine(p);
            Console.ReadLine();
        }
    }
}
