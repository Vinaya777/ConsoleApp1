using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DemoSr.VideoAssignment
{
    public static class PrintReverseList
    {
        public static void ReverseNum(this List<int> lplist)
        { 


        }
        static void Main(string[] args)
        {
            List<int> lplist = new List<int>() ;
            Console.WriteLine("Array List after reversing elements\n ");
            lplist.ReverseNum();
            //lplist.Reverse(5);

            lplist.Add(10);
            lplist.Add(10);
            lplist.Insert(1, 20);
            lplist.Add(89);
            lplist.Add(888);
            lplist.Add(20);
            lplist[0] = 100;
            //al.RemoveAt(0);
            //al.Remove(888);
            Console.WriteLine(lplist.Contains(200));
            Console.WriteLine(lplist.Count);

            foreach (var data in lplist)
                Console.WriteLine(data);
            lplist.Reverse();
            lplist.Sort();
            Console.WriteLine("========================");
            foreach (var data in lplist)
                Console.WriteLine(data);
        


        }
    }
}
