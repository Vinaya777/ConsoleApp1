using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ObjectAndClasses
{
    class ExmpleForStudy
    {
    }

    class Pen
    {
        int price;
        String color;
        String brand;

        public Pen()
        {

        }

        public void writing()
        {

        }
    }
    public class Student1
    {
        int id;
        string studentname;
        string qualification;
        protected long mobile; //instance
        static string trainername;

        static void setTrainerName(string tnm)
        {
            trainername = tnm;
        }

        void accept()
        {
            Console.WriteLine("enter id,name,qualification,mobile");
            id = int.Parse(Console.ReadLine());
            studentname = Console.ReadLine();
            qualification = Console.ReadLine();
            mobile = long.Parse(Console.ReadLine());
        }

        void input(int id, string studentname)
        {

            //this=currently invoking object reference
            this.id = id;
            this.studentname = studentname;
        }
        int square(int a)
        {
            int sq = a * a;
            return sq;

        }

        public void display()
        {
            Console.WriteLine($" Id:{id} Name:{studentname} qualification: {qualification} mobile: {mobile} ");
        }

        //constructor overloading
        //overloading
        //the number of parameter differ or data type differ or order differ

        //default constructor
        public Student1()
        {
            Console.WriteLine("default constructor invoked");
        }


        static Student1()
        {
            trainername = "deepa";
            Console.WriteLine("static constructor invoked");
        }
        //parameterized constructor
        public Student1(int id, string snm, string q, long mb)
        {
            this.id = id;
            this.studentname = snm;
            qualification = q;
            mobile = mb;
        }

        //para 2 para
        public Student1(int id, string nm)
        {
            this.id = id;
            this.studentname = nm;
        }


        static void Main(string[] args)
        {
            Student1 s1 = new Student1();
            s1.id = 101;
        }
    }

    class CollegeStudent : Student1
    {

        void m1()
        {
            Console.WriteLine(mobile);
        }
    }


    //class(blueprint) and object(instance of class)



}

