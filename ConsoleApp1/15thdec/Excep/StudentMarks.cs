using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1._15thdec.Excep
{
    class StudentMarks
    {
        int rollNo;
        string name;
        float marks;
       
        public void displayAvgMarks(int m)
        {
            float sum = 0.0f;
            for(int i = 0; i < m;i++)
            {
                sum += m;
            }
            Console.WriteLine("Average Of Marks=" + (sum / m));
        }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the Number:");
                int roll = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the Name:");
                string name = Console.ReadLine();

                Console.WriteLine("Enter the 5 Subject Marks");
                StudentMarks sm = new StudentMarks();
                for(int i = 0; i <= 5; i++)
                {

                    sm.marks = int.Parse(Console.ReadLine());
                }
                

            }
            catch (ArithmeticException)
            {
                Console.WriteLine("Erroe type is ArrayIndexOutOfBoundsException");
            }
            catch(Exception)
            {
                Console.WriteLine("Error message is InputMismatchException");
            }
            Console.ReadLine();
        }
        

    }
}
