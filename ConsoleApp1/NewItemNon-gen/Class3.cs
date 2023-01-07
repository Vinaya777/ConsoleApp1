using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.NewItem
{
    class Class3
    {
        static void Main(string[] args)
        {
            SortedList<int, string> sl = new SortedList<int, string>();
            sl.Add(234, "fsd");
            sl.Add(1, "sds");
            sl.Add(45, "dsf");
            foreach (var i in sl)
                Console.WriteLine(i.Key + "==>" + i.Value);

            SortedList<Student, long> ss = new SortedList<Student, long>(new sortByID());
            ss.Add(new Student(1, "deepa", 90), 35434646);
            ss.Add(new Student(2, "riya", 45), 35434646);
            ss.Add(new Student(4, "amey", 80), 35434646);
            foreach (var i in ss)
                Console.WriteLine(i.Key + "==>" + i.Value);

            Console.WriteLine("========================Stack================");
            //LIFO
            Stack<String> st = new Stack<string>();
            st.Push("A");
            st.Push("om");
            st.Push("C");

            Console.WriteLine("popped" + st.Pop());
            foreach (var i in st)
                Console.WriteLine(i);

            //FIFO
            Queue<int> q = new Queue<int>();
            q.Enqueue(90);
            q.Enqueue(89);
            Console.WriteLine("Dequeue  " + q.Dequeue());

            //

        }
    }
}
