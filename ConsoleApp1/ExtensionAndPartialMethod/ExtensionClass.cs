using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ExtensionAndPartialMethod
{

    public class Test1
    {
        public void M1()
        {
            // code
        }
        public void M2()
        {
            //
        }

        //extension method must be static method
        //class should be static
        //need to pass first parameter as refrence to classs
    }
    public static class ExtensionClass
    {
        public static void M3(this Test1 t1, string name) // extension method
        {
            Console.WriteLine("M3 method");
        }
         public static void M4(this Test1 t1, string name) // extension method
         {
             Console.WriteLine("M4 method " + name);
         }


    }
    public class Program
    {
        static void Main(string[] args)
        {
            Test1 t1 = new Test1();
            t1.M3("Heloo!!!!!!!!!!!");
            t1.M4("TQ");
        }


    }
}


