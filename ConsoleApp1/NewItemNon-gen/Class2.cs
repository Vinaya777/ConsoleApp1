using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.NewItem
{
    class Class2
    {
        static void Main1(string[] args)
        {
            LinkedList<string> ll = new LinkedList<string>();
            ll.AddFirst("Diya");
            ll.AddLast("Priya");
            ll.AddLast("Trupti");
            ll.AddLast("Diya");
            LinkedListNode<string> n1 = ll.Find("Priya");

            ll.AddAfter(n1, "Pranav");
            foreach (var ob in ll)
                Console.WriteLine(ob);
        }
        static void Main2(string[] args)
        {
            //hashing
            Dictionary<string, int> dict = new Dictionary<string, int>();
            dict.Add("Riya", 90);
            dict.Add("Diya", 89);
            dict.Add("Priya", 88);

            dict["Priya"] = 100;
            Console.WriteLine(dict.ContainsKey("Tiya"));
            dict.Remove("Diya");
            //Console.WriteLine("**"+dict["Diya"]);
            foreach (KeyValuePair<string, int> d in dict)
                Console.WriteLine(d.Key + "===>" + d.Value);


        }
        static void Main(string[] args)
        {
            /*Student s1 = new Student(1, "Riya", 90);
            Student s2 = new Student(1, "Riya", 90);
            Console.WriteLine(s1.GetHashCode());
            Console.WriteLine(s2.GetHashCode());*/

            Dictionary<Student, long> d2 = new Dictionary<Student, long>();
            d2.Add(new Student(1, "Riya", 90), 89999999);
            d2.Add(new Student(2, "Diya", 90), 89999999);
            //d2.Add(new Student(1, "Riya", 90), 89999999);

            foreach (KeyValuePair<Student, long> d in d2)
                Console.WriteLine(d.Key + "===>" + d.Value);

        }
    }
}
