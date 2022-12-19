using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ObjectAndClasses
{
    class BookDiscount
    {
        public class Book
        {
           private int bookID;
           private String bookName; private String aut;
          private  double price;
            

           public Book(int bId, String bName, float p,String aut)
            {
                this. bookID = bId;
                this. bookName = bName;
                this. price = p;
                this.aut = aut;
               
            }
            public override string ToString()
            {
                return $"Book name: {bookName}Authour Name:{aut},BookPrice:{price}";
            }

            public void calPrice()
            {
                price = (price - 10) / 100;
                Console.WriteLine(price);
                Console.ReadLine();
            }
            

        }



        public static void Main(string[] args)
        {

            Book b = new Book(125, "Ikigai", 600, "Franceesc Miralles");
            Console.WriteLine(b);
            b.calPrice();
            Console.WriteLine("Accessed Method in Classs ........");
            Console.ReadLine();
        }
    }
    
}
