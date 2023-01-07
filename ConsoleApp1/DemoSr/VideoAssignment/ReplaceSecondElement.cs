using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*WAP to replace the second element of an ArrayList with the specified element*/
namespace ConsoleApp1.DemoSr.VideoAssignment
{
    class ReplaceSecondElement
    {
        static void Main(string[] args)
        {
            String[] ch = { "A","B","C","D","E" };
            List<string> sl = new List<string>();
            sl.Add("Aamzon");
            sl.Add("Flipkart");
            sl.Add("Myntra");
            Console.WriteLine("Orignal list");
            sl.RemoveAt(1);
            sl.Insert(1, "Ajio");
            Console.WriteLine("After removing Flipkart"+sl);

        }
    }
}
