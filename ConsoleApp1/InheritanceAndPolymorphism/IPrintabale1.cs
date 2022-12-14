using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*Create an interface with name IPrintable which contains string Print() method

Implement the IPrintable interface in student class, employee class, circle class to print the student , employee & area of circle respectively

*/
namespace ConsoleApp1.InheritanceAndPolymorphism
{

    interface IPrintable1
    {
        void ReadFile();
        void WriteFile(string txt);
    }
    class Student : IPrintable1
    {
        void IPrintable1.ReadFile()
        {
            Console.WriteLine("Student Method called");
        }

        void IPrintable1.WriteFile(string txt)
        {
            Console.WriteLine("Employe method called");
        }

        public void Search(string txt)
        {
            Console.WriteLine("Correct Circle Area Method Call");
        }
    }

    public class Program
    {
        public static void Main()
        {
            IPrintable1 file1 = new Student();
            Student file2 = new Student();

            file1.ReadFile();
            file1.WriteFile("Is Employe On Work");
            //file1.Search("Area Is Finded");//

            file2.Search("Area Of Circle: "+(3.14*((5)^2)));
            //file2.ReadFile(); //
            //file2.WriteFile("Not Working"); //
        }
    }

}
