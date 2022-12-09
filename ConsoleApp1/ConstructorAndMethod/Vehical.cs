using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ConstructorAndMethod
{
    class Vehical
    {

        static void Swap(ref int price,ref int basicsaleprice)
        {
            int temp;
            temp = price;
            price = basicsaleprice;
            basicsaleprice = temp;
        }

        static void CarPrice(int price,int basicsaleprice,out int actualprice)
        {
            actualprice = price + basicsaleprice;
        }
        
        static void AcceptDetails(params string[] names)
        {
            Console.WriteLine("Names Of Car"+names.Length);
            for(int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);

            }

        }
        static void Main(string[] args)
        {
            AcceptDetails("BMW 3 Series 2022");
            AcceptDetails("Kia Carnival 2022.");
            AcceptDetails("New Variant. Toyota ");
            int price = 50000000;
            int basicsaleprice = 200000;
            Console.WriteLine($"Before Calling price={price}, basicsaleprice={basicsaleprice}");
            Swap(ref price, ref basicsaleprice);
            Console.WriteLine($"After calling price={price}, basicsaleprice={basicsaleprice}");
        }

    }
}
