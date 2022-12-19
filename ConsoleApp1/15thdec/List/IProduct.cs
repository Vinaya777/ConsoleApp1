using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1._15thdec.List
{
    public class IProduct
    {
        

        public int Id1 { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        public override string ToString()
        {
           return $"ID{Id1},name{Name},Price{Price}";
        }

        static void Main(string[] args)
        {
            List<IProduct> ll = new List<IProduct>();
            ll.Add(new IProduct { Id1 = 200, Name = "Mobile", Price = 40000 });
            ll.Add(new IProduct { Id1 = 250, Name = "Watch", Price = 40050 });
            ll.Add(new IProduct { Id1 = 290, Name = "Laptop", Price = 45000 });
            ll.Add(new IProduct { Id1 = 295, Name = "Mouse", Price = 400});

                foreach(IProduct ps in ll)
            {


                Console.WriteLine(ps);
            }
            Console.ReadLine();
            Console.WriteLine("Price less  than 2000rs.......................");
            foreach(IProduct ps in ll)
            {
                if (ps.Price < 2000)
                {
                    Console.WriteLine(ps);
                }
                Console.ReadLine();
            }
        }
    }

    
} 
