using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ObjectAndClasses
{
    class Department
    {
        int id;
        String name;

        public int Id { get => id; set => this.id = value; }
        public string Name { get => name; set => this.name = value; }

        Department(int id, String name)
        {
            this.id = id;
            this.name = name;
        }
        public void showDepartmentDetails()
        {
            Console.WriteLine("Department id: is" + id + "and name of department is" + name);
        }
    }
    /*class Studentt 
    {
        int roll;
        String name;
        Department d;

        public int Roll { get => roll; set => this.roll = value; }
        public string Name { get => name; set => this.name = value; }
        internal Department D { get => d; set => this.d. =value; }



        void displayStudentDetails()
        {
            d.showDepartmentDetails();
            Console.WriteLine("Student roll number is" + roll + "and name of student is" + name);

        }
        *//*public Studentt(int roll, String name, Department d)
        {
            this.roll = roll;
            this.name = name;
         
            
        }*//*

    } */
}


