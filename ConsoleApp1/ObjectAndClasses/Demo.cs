using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApp1.ObjectAndClasses
{
    class Demo
    {
        static void Main(string[] args)
        {
            Book bk = new Book();
            bk.Id = 1021;
            bk.Name = "As you like it";
            bk.Price = 500;
            bk.Author_name = "William Shakespeare";
            Book bk1 = new Book { Id = 12054, Name = "India Wins Freedom", Price = 250, Author_name = "Maulana Abul Kalama Azad" };

            Console.WriteLine(bk1);
        }
    }
}
