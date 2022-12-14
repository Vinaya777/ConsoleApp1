using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Mcq
{
    class ClassAbc
    {
        public static void a()
        {
            Console.WriteLine("First method");

        }
        public void b()
        {
            a();
            Console.WriteLine("Second method");
        }
        public void b(int i)
        {
            Console.WriteLine(i);
            b();
        }
        class Program
        {
            static void Main(string[] args)
            {
                ClassAbc abc = new ClassAbc();
                /* abc.a();
                 abc.(20);*/
                abc.b(20);
                Console.WriteLine(abc);
                Console.ReadLine();
            }
        }
    }
}