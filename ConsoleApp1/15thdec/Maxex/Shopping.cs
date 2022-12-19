using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1._15thdec.Maxex
{
    class Shopping
    {
        string clothesShop;
        int clothePrice;

        public Shopping(string clothesShop, int clothePrice)
        {
            this.clothesShop = clothesShop;
            this.clothePrice = clothePrice;
        }

        public string ClothesShop { get => clothesShop; set => clothesShop = value; }
        public int ClothePrice { get => clothePrice; set => clothePrice = value; }

        static void Main(string[] args)
        {

            LinkedList<string> shop = new LinkedList<string>();

            shop.AddFirst("T-shirt");
            shop.AddFirst("Pants");
            shop.AddFirst("bag");
            shop.AddLast("Chapple");
            
            LinkedListNode<string> node = shop.Find("bag");
            shop.AddAfter(node, "Shirt");
            foreach(var ss in shop)
            {
                Console.WriteLine(ss);  
            }Console.ReadLine();


        }
    }
}
