using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1._15thdec.Book
{
    public enum bookCategoriesList {Humor,SciFi,Mystery,Thriller}
    class AccessBook
    {
        static void Main(string[] args)
        {
            List<Book> booklist = new List<Book>()
            {
                new Book()
                {
                 bookauthurName="Preeti Shenoy",booklibrarylist=new List<BookLibrary>()
                 {
                     new BookLibrary(){ bookcategories=bookCategoriesList.SciFi,bookno=5202,publisher="IndiaExpress",bookname="Happens for reason"},
                     new BookLibrary(){bookcategories=bookCategoriesList.Thriller,bookno=2555,publisher="Westland Books",bookname="MagicMindSet"},
                     new BookLibrary(){bookcategories=bookCategoriesList.Mystery,bookno=85444,publisher="Western publiser",bookname="A Place call Home"}
                 }
                 
                },
                new Book()
                {
                    bookauthurName="Bimal Jalan",booklibrarylist=new List<BookLibrary>()
                    {
                        new BookLibrary(){bookcategories=bookCategoriesList.Mystery,bookno=52452,publisher="Ru Publications India Pvt",bookname="Indias Economic Crisis "},
                        new BookLibrary(){bookcategories=bookCategoriesList.Humor,bookno=65475,publisher="IndianEconomic",bookname="Indian Politics"},
                        new BookLibrary(){bookcategories=bookCategoriesList.SciFi,bookno=87544,publisher="thriftbook",bookname="Future Of India"}
                    }
                },
                new Book()
                {
                    bookauthurName="Robert t kiyosaki",booklibrarylist=new List<BookLibrary>()
                    {
                        new BookLibrary(){bookcategories=bookCategoriesList.Thriller,bookno=45674,publisher="revelled publisher",bookname="Rich Dad Poor Dad"},
                        new BookLibrary(){bookcategories=bookCategoriesList.Thriller,bookno=45674,publisher="revelled publisher",bookname="Rich Dad’s Before you Quit your Job"},
                        new BookLibrary(){bookcategories=bookCategoriesList.Thriller,bookno=45674,publisher="revelled publisher",bookname="Rich Dad’s Who Took My Money"}
                    }
                }
                
            };
            foreach (var books in booklist)
            {
                Console.WriteLine();

                foreach (var item in booklist)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
