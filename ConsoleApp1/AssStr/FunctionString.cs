using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.AssStr
{
    class FunctionString
    {
        static void Main(string[] args)
        {
            string firstname;
            string lastname;

            firstname = "Vinaya";
            lastname = "Gaikwad";

            Console.WriteLine(firstname.Clone());
            Console.WriteLine(firstname.CompareTo(lastname));

            Console.WriteLine(firstname.Contains("vin"));
            Console.WriteLine(firstname.EndsWith("n"));
            Console.WriteLine(firstname.Equals(lastname));
            Console.WriteLine(firstname.GetHashCode());
            Console.WriteLine(firstname.GetType());
            Console.WriteLine(firstname.GetTypeCode());
            Console.WriteLine(firstname.IndexOf("a")); //Returns the first index position of specified value
                                                       // the first index position of specified value

            Console.WriteLine(firstname.ToLower());
            Console.WriteLine(firstname.ToUpper());
            Console.WriteLine(firstname.Insert(0, "Hello"));
            Console.WriteLine(firstname.IsNormalized());
            Console.WriteLine(firstname.LastIndexOf("i"));
            Console.WriteLine(firstname.Length);
            Console.WriteLine(firstname.Remove(5));
            Console.WriteLine(firstname.Replace('a', 'i'));


            string[] split = firstname.Split(new char[] { 'e' }); //Split the string based on specified value


            Console.WriteLine(split[0]);
            Console.WriteLine(split[1]);
            Console.WriteLine(split[2]);

            Console.WriteLine(firstname.StartsWith("S")); //Check wheter first character of string is same as specified value

            Console.WriteLine(firstname.Substring(2, 5));
            //Returns substring

            Console.WriteLine(firstname.ToCharArray());
            //Converts an string into char array.

            Console.WriteLine(firstname.Trim());
            //It removes starting and ending white spaces from string.
        }
    }
}
