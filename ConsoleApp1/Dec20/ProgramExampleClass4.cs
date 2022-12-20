using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Dec20
{
    class ProgramExampleClass4
    {
        static void Main(string[] args)
        {
            /* string s = "ThinkQuotient";
            string ss = "ThinkQuotient";
            //literal intern pool which stores unique string  object 
            string s2 = new string("riya");  //on heap
            string s4 = new string("riya");
            Console.WriteLine(s2==s4);
            Console.WriteLine(object.ReferenceEquals(s2,s4));
            Console.WriteLine("***************");
            Console.WriteLine(s == ss);
            Console.WriteLine(object.ReferenceEquals(s, ss));
            //operator overloading
            //==
            int a = 10, b = 90;
            // Console.WriteLine(a==b);*/


            //String str = "dasd";

            string s = "sonal"; //immutable 
            string s2 = s + "patil";
            s = s.ToUpper();
            string str = "  PRIYA  ";
            Console.WriteLine(str.Length);
            str = str.Trim();
            str = str.ToLower();
            Console.WriteLine(s);
            Console.WriteLine(s2);
            Console.WriteLine(str);
            string sr = s2.Replace('a', 'u');
            Console.WriteLine(sr);
            Console.WriteLine(s2.Substring(5));
            Console.WriteLine(s2.Substring(5, 3));
            string str2 = "my name is priya";
            string[] arr = str2.Split();
            char[] carr = str2.ToCharArray();


            foreach (string sss in arr)
                Console.WriteLine(sss);

            //string nm1 = new string(" ");
            string nm2 = "priya";
          //  Console.WriteLine(nm1 == nm2);
           // Console.WriteLine(nm1.Equals(nm2));
            Console.WriteLine("deepa".CompareTo("diya"));

            Console.WriteLine("enter ur name");
            string name = Console.ReadLine();
            int v = 0;
            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] == 'a' || name[i] == 'e' || name[i] == 'i' || name[i] == 'o' || name[i] == 'u')
                    v++;
            }
            Console.WriteLine("No of vowels " + v);


            foreach (char ch in name)
                Console.WriteLine(ch);

            //str1==str2=0
            //str1<str2 return -1
            //str1>str2 return +1







            Console.WriteLine(str.Length);
        }

    }
}

