using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1._15thdec.Excep
{

    public class MarksException : Exception
    {
        public MarksException(string message) : base(message)
        {

        }
    }
    public class NameException : Exception
    {
        public NameException(string message) : base(message)
        {

        }
    }

    public class Stud
    {
        private int marks;
        private string name;

        public void AcceptName(string name)
        {
            if(string.IsNullOrEmpty(name))
            {

                throw new NameException("Name Of Student Not Present");

            }
            else
            {
                this.name = name;
            }
            
        }
        public void AcceptMarks(int marks)
        {
            if (marks > 100)
            {
                throw new MarksException("Marks can not be greater than 100");
            }
            else
            {
                this.marks = marks;
            }
        }

        static void Main(string[] args)
        {
            Stud s = new Stud();
            try
            {
                s.AcceptMarks(101);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine();
        }

    }
}

