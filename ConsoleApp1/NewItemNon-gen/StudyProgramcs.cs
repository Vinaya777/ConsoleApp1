using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 
 System.Collections                   System.Collections.Generic  
 Non - generic (heterogenous)         Generic(homogenouss)
 ArrayList     ------------->         List<T>,LinkedList<T>
 HashTable     ------------->         Dictionary<Tkey,TValue>
 SortedList    ------------->         SortedList<Tkey,TValue>
 Stack         ------------->         Stack<T>
 Queue         ------------->         Queue<T>  
                                      HashSet<T>
                                      SortedSet<T>*/
namespace ConsoleApp1.NewItem
{
    class StudyProgramcs
    {
        static void Main(string[] args)
        {

            ArrayList al = new ArrayList(100);
            al.Add("Python");
            al.Add("C#");
            al.Add("Angular");
            al.Add("Java");
            al.Add("Vuejs");
            al.Insert(0, "React");
            al[0] = "DataScience";
            al.Sort();
            al.TrimToSize();
            for (int i = 0; i < al.Count; i++)
            {
                Console.WriteLine(al[i]);
            }

            //key-value pair
            //id 
            Hashtable ht = new Hashtable();
            ht.Add(101, "Riya");
            ht.Add(102, "deepa");
            ht.Add(103, "fdsf");
            ht.Add(104, "Riya");
            ht.Add(5, "A0");
            ht.Add("ddd", "dd");
            ht.Add(23.4f, "fsdf");

            //ht[102] = "Sonal";

            Console.WriteLine("Contains KEy" + ht.ContainsKey(109));
            Console.WriteLine("Contains Value " + ht.ContainsValue("deepa"));
            Console.WriteLine(ht[104]);
            //ht.Remove(101);
            foreach (DictionaryEntry d in ht)
                Console.WriteLine(d.Key + "=>" + d.Value);
            Console.WriteLine("--------------------------------------");
            foreach (var k in ht.Keys)
                Console.WriteLine(ht[k]);

            //
            //LIFO
            Console.WriteLine("==============Stack====================");
            /*Stack st = new Stack();
            st.Push(10);
            st.Push("A");
            st.Push("B");*/
            //Console.WriteLine(st.Pop());
           // Console.WriteLine(st.Peek());
            //st.Clear();

            //foreach (object o in st)
                //Console.WriteLine("**" + o);

            Console.WriteLine("--------------Queue-----------------");
            //FIFO
            Queue q = new Queue();
            q.Enqueue(10);
            q.Enqueue(20);
            q.Enqueue(30);
            Console.WriteLine(q.Dequeue());

            foreach (object o in q)
                Console.WriteLine("**" + o);

            Console.WriteLine("------------------Sortedlist---------");

            //
            SortedList s = new SortedList();
            s.Add(103, "fdsf");
            s.Add(1, "dsaf");
            s.Add(10, "om");
            foreach (DictionaryEntry d in s)
                Console.WriteLine(d.Key + "==>" + d.Value);

            // ht.Add(null, "sfs");
            //Console.WriteLine(ht[101]);
            // ht.Add(101, "Om");

            //hashCode(key) and equals()
            //bucket

            // al.Remove("python");
            //al.RemoveAt(0);
            /*foreach (var i in al)
                Console.WriteLine(i);*/
            /* Console.WriteLine("----------------------------------");
             al.Reverse();
             Console.WriteLine("Count "+al.Count);
             //al.Clear();
             Console.WriteLine("Count " + al.Count);
             foreach (var i in al)
                 Console.WriteLine( i);*/




        }
    
    }
}
