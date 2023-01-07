using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*WAP of swap two elements in an ArrayList*/
namespace ConsoleApp1.DemoSr.VideoAssignment
{
    public static class SwapTwoElt
    {
        public static void Swap<T>(this List<T> list, int i, int j)
        {
            T temp = list[i];
            list[i] = list[j];
            list[j] = temp;
        }
        static void Main(string[] args)
        {
            List<int> nums = new List<int>() { 1, 2, 3, 4, 5 };

            nums.Swap(2, 3);
            Console.WriteLine(String.Join(", ", nums));
        }
    }
}
