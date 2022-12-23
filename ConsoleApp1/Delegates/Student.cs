using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Delegates
{
    public delegate void MyResult();

   public class Student
    {
        public event MyResult Pass;
        public event MyResult Fail;
        public void Accept(int marks)
        {
            if (marks >= 40)
            {
                Pass(); //raise an event
            }
            else
            {
                Fail();
            }


        }
    }
    public static class Message
    {
        public static void PassMessage()
        {
            Console.WriteLine("Passsed  :-).......!!!!!!!!!!!");
        }
        public static void FailMessage()
        {
            Console.WriteLine("Fail :-(............!!!!!!!!!!!");
        }
    }
    public class Sample
    {
        static void Main(string[] args)
        {
            Student studentobj = new Student();
            studentobj.Pass += new MyResult(Message.PassMessage);
            studentobj.Fail += new MyResult(Message.FailMessage);
            Console.WriteLine("End ...!!!!!!!!!!!!!!!");
            Console.ReadLine();
        }
    }
}
