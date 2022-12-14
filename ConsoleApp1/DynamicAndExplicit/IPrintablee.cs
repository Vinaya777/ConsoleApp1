using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Create an interface with name IPrintable which contains string Print() method

Implement the IPrintable interface in student class, employee class, circle class to print the student , employee & area of circle respectively
*/
namespace ConsoleApp1.DynamicAndExplicit
{
    interface IPrintablee
    {
        void PrintLine();

        string Print();
    }
    class Student 
    {
        public void Print()
        {
            Console.WriteLine("In method Student");
        }
    }
    class Employe :Student
    {
        public void Print()
        {
            Console.WriteLine("Inside Employee Method");
        }
    } 
   public class Circle 
    {
        public void Print()
        {
            Console.WriteLine("Inside Circle Area of Circle");
        }


        static void Main(string[] args)
        {
            
        }
    }
   
}
