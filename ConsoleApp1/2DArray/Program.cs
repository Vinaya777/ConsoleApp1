using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1._2DArray
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            Console.WriteLine($"Capacity ->{list.Capacity}");
            int[] arr = new int[] { 100, 200, 300 };
            list.Add(10);  // boxing
            list.Add("Hello");
            list.Add(67.88);

            Console.WriteLine($"Capacity ->{list.Capacity}");
            //string name =list[1].ToString();

            //double d = Convert.ToDouble(list[2]);  // unboxing

            list.Insert(0, 5);
            list.Insert(2, 15);

            list.AddRange(arr);
            Console.WriteLine($"Capacity ->{list.Capacity}");
            // list.Remove(67.88);
            // list.RemoveAt(3);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------------");
            // list.RemoveRange(3, 4);

            list.Clear();

            Console.WriteLine($"Capacity ->{list.Capacity}");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            list.Sort();
            list.Reverse();


        }
    }
}
