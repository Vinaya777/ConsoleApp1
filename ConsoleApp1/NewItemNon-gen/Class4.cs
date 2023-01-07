using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.NewItem
{
    class Class4
    {
        static void Main(string[] args)
        {
            ///unique and insertion not preserved
            //hashing--
            /* HashSet<string> hs = new HashSet<string>();
             hs.Add("A");
             hs.Add("B");
             hs.Add("C");
             hs.Add("Amey");
             hs.Add("Amit");
             hs.Remove("A");
             Console.WriteLine("contains "+hs.Contains("A"));
             Console.WriteLine(hs.Count);

             Console.WriteLine(hs.Add("C"));
 */

            HashSet<Student> hs = new HashSet<Student>();
            hs.Add(new Student(1, "Amey", 90));
            hs.Add(new Student(2, "Ameya", 90));
            hs.Add(new Student(1, "Amey", 90));

            //hashcode(key)
            //equals()--true it duplicate
            //false

            foreach (var ob in hs)
                Console.WriteLine(ob);
            Console.WriteLine("=============sortedset==================");
            /*SortedSet<int> ss = new SortedSet<int>();
            ss.Add(90);
            ss.Add(8);
            ss.Add(1);*/


            SortedSet<Student> ss1 = new SortedSet<Student>(new sortByPercent());
            ss1.Add(new Student(1, "Adi", 90));
            ss1.Add(new Student(2, "Ameya", 80));
            ss1.Add(new Student(3, "Amit", 82));


            foreach (var ob in ss1)
                Console.WriteLine(ob);


        }
    }
}
