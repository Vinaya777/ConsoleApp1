using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ObjectAndClasses
{

    //public-->that member is accessible with current and another assembly
    //private->only within that class
    //internal->within current assembly(within curr project)
    //protected->only in subclass


    //by default if before class you dont specify default access modifier internal
    //all members inside class if you dont specify by default are private
    
      /*  class Test
        {
            static void Main(string[] args)
            {
                Student s1 = new Student();


                //s1.id = 101;
                Console.WriteLine("hiii");
            }
        }
    }*/
}

/*namespace com
{
    class testmain
    {
        static void Main(string[] args)
        {
            Student2 s1 = new Student2();
        }
    }
}
*/