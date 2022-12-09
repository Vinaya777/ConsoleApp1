using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ObjectAndClasses
{
    class Book
    {
         string name;
         int id;
         string author_name;
         float price;

        public string Name { 
            get => name; 
            set => name = value; 
        }
        public int Id {
            get => id;
            set => id = value;
        }
        public string Author_name { 
            get => author_name; 
            set => author_name = value;
        }
        public float Price {
            get => price;
            set => price = value;
        }
        public double CalculatePrice()
        {
            return Price * (1 + price);
        }

        public override string ToString()
        {
            return $"Aurthor_name{author_name},Book id{id}";
        }
        static void Main(string[] args)
        {
            /*Book b = new Book();
            b.author_name = "Raj";
            b.name = "Tow State";
            b.id = 101;
            b.price = 350;
            Console.WriteLine(b.author_name+" "+b.id+" "+b.name+" "+b.author_name+" ");
            Console.ReadLine();
            b.CalculatePrice();
*/


        }
    }
}
