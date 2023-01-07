using System;
using System.Collections.Generic;
using System.Text;



/*
 System.Collections                   System.Collections.Generic  
 Non - generic (heterogenous)         Generic(homogenouss)
 ArrayList     ------------->         List<T>,LinkedList<T>
 HashTable     ------------->         Dictionary<Tkey,TValue>
 SortedList    ------------->         SortedList<Tkey,TValue>
 Stack         ------------->         Stack<T>
 Queue         ------------->         Queue<T>  
                                      HashSet<T> hashcode
                                      SortedSet<T> --sorted
*/
namespace ConsoleApp1.NewItem
{
    class Class1
    {

        static void Main1(string[] args)
        {
            //Ds->growable array
            List<int> al = new List<int>();
            al.Add(10);
            al.Add(10);
            al.Insert(1, 20);
            al.Add(89);
            al.Add(888);
            al.Add(20);
            al[0] = 100;
            //al.RemoveAt(0);
            //al.Remove(888);
            Console.WriteLine(al.Contains(200));
            Console.WriteLine(al.Count);

            foreach (var data in al)
                Console.WriteLine(data);
            al.Reverse();
            al.Sort();
            Console.WriteLine("========================");
            foreach (var data in al)
                Console.WriteLine(data);
        }


        static void Main(string[] args)
        {

            //Console.WriteLine("amey".CompareTo("diya"));
            List<Student> slist = new List<Student>();
            slist.Add(new Student(1, "Riya", 90));
            slist.Add(new Student(11, "Diya", 92));
            slist.Add(new Student(18, "Tiya", 89));
            slist.Add(new Student(2, "Piya", 78));
            slist.Add(new Student(4, "Hiya", 80));
            //slist.Reverse();
            // slist.Sort();
            // slist.Sort(new sortByPercent());
            slist.Sort(new sortByID());
            foreach (var sobj in slist)
                Console.WriteLine(sobj);
        }

    }
    //IComparable original class and single sort logic
    //IComparer

    class sortByPercent : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            Console.WriteLine("in comparer");
            return x.Percent - y.Percent;
        }
    }

    class sortByID : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            return x.Sid - y.Sid;
        }
    }



    class Student : IComparable<Student>
    {
        int sid;
        string name;
        int percent;



        public Student(int sid, string name, int percent)
        {
            this.Sid = sid;
            this.Name = name;
            this.Percent = percent;
        }

        public int Sid { get => sid; set => sid = value; }
        public string Name { get => name; set => name = value; }
        public int Percent { get => percent; set => percent = value; }
        public object HashCode { get; private set; }

        public int CompareTo(Student other)
        {
            Console.WriteLine("Comparable");

            /* if (this.sid < other.sid)
                 return -1;
             else if (this.sid > other.sid)
                 return +1;
             else
                 return 0;*/
            //return this.sid - other.sid;

            //return other.percent - this.percent;
            return this.name.CompareTo(other.name);
        }

        public override bool Equals(object obj)
        {
            return obj is Student student &&
                   sid == student.sid &&
                   name == student.name &&
                   percent == student.percent;
        }

       /* public override int GetHashCode()
        {
            return HashCode.Combine(sid, name, percent);
        }*/

        public override string ToString()
        {
            return $"Id={sid} Name={name} Percentage={percent} ";
        }
    }
}
