using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ObjectAndClasses
{
    class Author
    {
        int aid; string aname;
        float aprice, aaurthor;

        public int Bookid { get; set; }

        public string Bookname { get; set; }

        public float BookPrice { get; set; }

        public string BookAurhorName { get; set; }

        public override string ToString()
        {
            return $"{Bookid}-{Bookname}";
        }
    }
}
