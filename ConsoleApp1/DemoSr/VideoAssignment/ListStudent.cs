using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*WAP to create a List of Students and iterate over it.*/
namespace ConsoleApp1.DemoSr.VideoAssignment
{
   public class ListStudent
    {
        public string nameStudent { get; set; }
        public int Idnumber { get; set; }
        static void Main(string[] args)
        {
            List<ListStudent> liststudent = new List<ListStudent>();
            liststudent.Add(new ListStudent {nameStudent="Vinaya",Idnumber=00252 });
            liststudent.Add(new ListStudent { nameStudent = "Tejswani", Idnumber = 00255 });
            liststudent.Add(new ListStudent { nameStudent = "Rajshreee", Idnumber = 00256 });
            liststudent.Add(new ListStudent { nameStudent = "Raj", Idnumber = 00257 });
            liststudent.Add(new ListStudent { nameStudent = "Depali", Idnumber = 00258 });


        }
    }
}
