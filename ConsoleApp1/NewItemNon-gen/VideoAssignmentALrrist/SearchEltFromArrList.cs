using System;
using System.Collections;
using System.Text;


namespace ConsoleApp1.NewItemNon_gen.VideoAssignmentALrrist
{
    class SearchEltFromArrList
    {
        public class ArrayList
        {

            public int StudentID { get; set; }
            public string StudentName { get; set; }
            public int Age { get; set; }
            public string Address { get; set; }



        }
        static void Main(string[] args)
        {
            ArrayList arlist = new ArrayList() {
                StudentID = 1,
                StudentName = "Bill",
                Age = 20,
                Address = "New York"
            };
            ArrayList arlist1 = new ArrayList()
            {
                StudentID = 2,
                StudentName="Heli",
                Age=21,
                Address="Germany"
                

            };
            ArrayList al = new ArrayList();
            
            Console.WriteLine(arlist);
            Console.ReadLine();
            
            


		}
	}
}
