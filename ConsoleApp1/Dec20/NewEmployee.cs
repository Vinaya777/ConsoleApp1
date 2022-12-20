using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Dec20
{
    
       class NewEmployee // public struct NewEmployee
         {
        int id;
        String name;
        int salary;
       // Department dept;
        //  MyDate date;

        public NewEmployee(int id, String name, int salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
            /*dept = d;
            date = m;*/
        }
       /* public Department(int d)
        {
            this.dept = dept;
            return dept;
        }*/

        public void AcceptDetails(NewEmployee[] e)
        {
            for (int i = 0; i <= e.Length; i++)
            {
                Console.WriteLine("Enter Employee id: ");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Employee Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Employee Salary: ");
                int salary = int.Parse(Console.ReadLine());


            }


        }
        public void sortEmpAscAccordingToSalary(NewEmployee[] e)
        {
            NewEmployee temp;

            for (int i = 0; i < e.Length; i++)
            {
                for (int j = i + 1; j < e.Length; j++)
                {
                    if (e[i].salary > e[j].salary)
                    {
                        temp = e[i];
                        e[i] = e[j];
                        e[j] = temp;
                    }
                }
            }
            Console.WriteLine("After Sorting Employee Record in Asscending Order according to salary: ");
            foreach(NewEmployee ee in e) 
            {
                Console.WriteLine(ee);
            }
        }
       

        public void EmployeeSalGreaterThan1000(NewEmployee[] e)
        {
            Console.WriteLine("Details Of Employee whose Salary is greater than 10000.......");
            foreach(NewEmployee val in e)
            {
                if (val.salary > 1000)
                {
                    Console.WriteLine(val);
                }
            }
        }

        public void DisplayNewEmployee(NewEmployee[] details)
        {
            Console.WriteLine("Employee Details are.............");
            foreach (NewEmployee det in details)
            {
                Console.WriteLine(details);
            }
            Console.WriteLine("####################################################");
        }
        /*public override string ToString()
        {
            return $"NewEmployee{id}, NewEmployee name{name},NewEmployee salary {salary}";

        }*/

        
            static void Main(string[] args)
            {
            Console.WriteLine("Enter the Number Of Employeees: ");
           // int size[] = int.Parse(Console.ReadLine());
           // Console.WriteLine(size);
            NewEmployee[] e = new NewEmployee[5];
            NewEmployee e1;//struct method calling for struct employee 
            NewEmployee nemp = new NewEmployee(121, "ABC", 2500000);
            nemp.AcceptDetails(e);
            nemp.sortEmpAscAccordingToSalary(e);
            nemp.EmployeeSalGreaterThan1000(e);
            nemp.DisplayNewEmployee(e);
            Console.Write(e);

            }
        }
 }
