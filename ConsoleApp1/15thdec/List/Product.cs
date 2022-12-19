using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1._15thdec.List
{
    class Product
    {
        String productName;
        int productPrice;
         public Product(String name,int price)
        {
            this.productName = name;
            this.productPrice = price;
        }
         public override string ToString()
        {
            return $"Product Name{productName},Product Price{productPrice}";
        }
        static void Main(string[] args)
        {
            List<Product> productslist = new List<Product>();
            productslist.Add(new Product("Jeans",205));
            productslist.Add(new Product("Tshirt", 350));
            productslist.Add(new Product("Kurti", 350));
            productslist.Add(new Product("Chapple", 450));
            foreach(var item in productslist)
            {
                Console.WriteLine(item);
            }
            
            productslist.RemoveAt(0);
            foreach (var item in productslist)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

            ///////////////////////////////////////////////////////////////////////////////////////////
            ///

            Queue<String> personqeue = new Queue<string>();
            personqeue.Enqueue("Girl1");
            personqeue.Enqueue("Girl2");
            personqeue.Enqueue("Girl3");
            personqeue.Enqueue("Girl4");
            personqeue.Enqueue("Girl5");

            foreach(var item in personqeue)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
            personqeue.Dequeue();
            foreach(var item in personqeue)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
            Dictionary<int, List<Product>> productwithPrices = new Dictionary<int, List<Product>>();
            List<Product> productslist100 = new List<Product>();
            List<Product> productslist200 = new List<Product>();
            List<Product> productslist300 = new List<Product>();
            productslist100.Add(new Product("Jeans1", 100));
            productslist100.Add(new Product("Jeans2", 100));
            productslist100.Add(new Product("Jean3", 100));

            productslist200.Add(new Product("Shirt1", 200));
            productslist200.Add(new Product("Shirt2", 200));
            productslist200.Add(new Product("Shrit3", 200));

            

            productwithPrices.Add(100, productslist100);
            productwithPrices.Add(200, productslist200);

            foreach (KeyValuePair<int, List<Product>> item in productwithPrices)
            {
                foreach (var product in item.Value)
                {
                    Console.WriteLine(item.Key + " " + product);
                }
            }

            Console.ReadLine();

            Stack<String> s1 = new Stack<string>();
            s1.Push("Hello");
            s1.Push("HeYYYYYYYYYYYYY!!!!!!!");
            s1.Push("Managable");
            foreach(var item in s1)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
            s1.Pop();
            foreach(var item in s1)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
           //HashTable ht = new HashTable();


        }
    }
}
