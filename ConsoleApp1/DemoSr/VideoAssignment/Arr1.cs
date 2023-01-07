using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*WAP to add elements to and print content of it where Integer is used. In the second arraylist String is used*/
namespace ConsoleApp1.DemoSr.VideoAssignment
{
    public class Arr1
    {
        public class Contacts
        { 
            public  string Name { get; set; }
            public int phoneNumber { get; set; }

            public int Age { get; set; }
            static void Main(string[] args)
            {
                var InName = new List<String>();
                InName.Add("Geeta");
                InName.Add("Sageeta");
                InName.Add("Urmi");
                InName.Add("Manjiri");


                //using for loop
                for (int i = 0; i < InName.Count; i++)
                {
                    Console.WriteLine(InName[i]);
                }

                List<Contacts> mycontacts = new List<Contacts>();
                mycontacts.Add(new Contacts
                {
                    Name = "Vinaya", phoneNumber=968998,Age=27
                });

                mycontacts.Add(new Contacts
                {
                    Name = "Manisha",
                    phoneNumber = 968988,
                    Age = 26
                });
                mycontacts.Add(new Contacts
                {
                    Name = "Mayuri",
                    phoneNumber = 868988,
                    Age = 28
                });

                foreach (var contact in mycontacts)
                {
                    Console.WriteLine(contact.Age);
                    Console.WriteLine(contact.Name);
                    Console.WriteLine(contact.phoneNumber);
                    Console.WriteLine(string.Join(", ", contact.Name));
                }
            }

            }
        }
 }

