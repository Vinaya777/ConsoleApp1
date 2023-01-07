using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*WAP to create a new ArrayList, add some colors (string) and print the collection.*/
namespace ConsoleApp1.DemoSr.VideoAssignment
{
    class ArrayList
    {
        static void Main(string[] args)
        {
            String[] str = { "Pinky", "Red", "Blue", "Orange", "White", "Black" };
            List<string> al = str.ToList();
            Console.WriteLine(string.Join(" ,", al));

        }
    }
}
