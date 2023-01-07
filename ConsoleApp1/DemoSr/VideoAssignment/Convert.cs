using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*WAP to convert an array to ArrayList.*/
namespace ConsoleApp1.DemoSr.VideoAssignment
{
    public class Convert
    {
        static void Main(string[] args)
        {/*
            String[] h = { "Read", "Write", "dance", "Play" };
          
            ArrayList list = new ArrayList();
            h.ToList();
            Console.WriteLine(list);
            Console.ReadLine();*/


            int[] array = { 1, 2, 3, 4, 5 };
            List<int> list = array.ToList();

            List<int> list1 = array.OfType<int>().ToList();
            List<int> list2 = array.Cast<int>().ToList();

            Console.WriteLine(String.Join(",", list));
            Console.ReadLine();

        }
    }
}
