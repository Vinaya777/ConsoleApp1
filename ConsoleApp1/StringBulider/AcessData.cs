using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.StringBulider
{
    class AcessData
    {
        public class Product
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Price { get; set; }
            public class Program
            {
                static void Main(string[] args)
                {
                    Product[] productlist = new Product[3]
                    {
                     new Product{Id=1,Name="mouse",Price=999},
                     new Product{Id=2,Name="keyboard",Price=1999},
                      new Product{Id=3,Name="pendrive",Price=2999}
                    };
                    foreach (Product p in productlist)
                    {
                        Console.WriteLine($"{p.Id} {p.Name} {p.Price}");
                    }



                }
            }
            static void Main(string[] args)
            {

                string str = "hello";
                Console.WriteLine(str);
                Console.WriteLine(str.GetHashCode());// returns the add loc

                str = str + " good morning";
                Console.WriteLine(str);
                Console.WriteLine(str.GetHashCode());


                StringBuilder sb = new StringBuilder("hello");
                Console.WriteLine(sb);
                Console.WriteLine(sb.GetHashCode());

                sb.Append(" good morning");
                Console.WriteLine(sb.GetHashCode());
                Console.WriteLine(sb);

            }
        }
    }
}