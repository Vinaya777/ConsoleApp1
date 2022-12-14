using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.InheritanceAndPolymorphism
{
    public class University
    {
       protected String course;
     protected   String name;

       public  University(String course, String name)
        {
            this.course = course;
            this.name = name;
        }
        public virtual void ShowUniversityDetails()
        {
            Console.WriteLine("University name:" + name);
            Console.WriteLine("Name of Course:"+course);

        }


        public class College:University
        {
           private int regNo;
             private   String clgName;
            College(int regNo, String clgName): base("IT","Manisha" )
            {
                this.regNo = regNo;
                this.clgName = clgName;
               
            }
            public  void ShowCollegeDEtails()
            {
                ShowCollegeDEtails();
                Console.WriteLine("Registration number is :"+regNo);
                Console.WriteLine("Colleage Name is: "+clgName);
            }

        }
        
    }
}
