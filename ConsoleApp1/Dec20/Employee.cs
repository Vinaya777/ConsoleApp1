using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Dec20
{
    public class Employee
    {
        private int esaly;
        private string ename;
        private int eid;
        private int emobile;

        public int Eid { get => eid; set => eid = value; }
        public int Emobile { get => emobile; set => emobile = value; }
        public int Esaly { get => esaly; set => esaly = value; }
        public string Ename { get => ename; set => ename = value; }


        public override string ToString()
        {
            return $"Eid {eid} Emobile{emobile} Esaly{esaly}";
        }
    }
    class Student 
    {
        int id;
        string name;

        public Student() : this(1, "Hey!!!!!!")
        {
            Console.WriteLine("I am Student");
        }
        public Student(int id, string name)
        {
            this.id = id;
            this.name = name;
            this.Display();
        }
        public void Display()
        {
            Console.WriteLine(id + " " + name);
        }
        static void Main(string[] args)
        {
            Student s = new Student();
            s.Display();
            Console.WriteLine(s);
            Console.ReadLine();
            Employee ep = new Employee();


            Student[] sslist = new Student[]
            {
                new Student{ id=121,name="Vinaya"},
                new Student{ id=123,name="Vini"}

            };
            foreach(Student ss in sslist)
            {
                Console.WriteLine(sslist);
            }
            Employee[] emplist = new Employee[]
            {
            new Employee{Eid=12,Ename="Vinaya"},
            new Employee { Eid = 25, Ename = "Xyz" },
            new Employee{ Eid=25,Ename="Abc"},
            };
            
           foreach(Employee emp in emplist)
            {
                Console.WriteLine(emplist);
            }

        }
    }
}

