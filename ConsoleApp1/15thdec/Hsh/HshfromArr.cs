using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1._15thdec.Hsh
{
    public class HshfromArr
    {

       public List<int> acceptarryList()
        {
            List<int> list = new List<int>();

            list.Add(85);
            list.Add(65);
            list.Add(25);
            list.Add(12);
            list.Add(14);
            list.Add(45);

            return list;

        }
        public void displayHashSet(List<int> list)
        {
            Console.WriteLine("Hash Set...................................");
            HashSet<int> hset = new HashSet<int>(list);
            foreach ( int item in hset)

            {
                Console.WriteLine(hset);
            }
        }
        static void Main(string[] args)
        {
            HshfromArr hshfromArr = new HshfromArr();
            List<int> list = new List<int>();
            hshfromArr.acceptarryList();
            // hshfromArr.displayHashSet();
            Console.ReadLine();

        }
    }
}
