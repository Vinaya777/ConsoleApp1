using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DemoA
{
    class AnagramExample
    {
        class Anagram
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Fist Word");
                string s = Console.ReadLine();
                char[] ch = s.ToCharArray();
                Console.WriteLine("Second Word");
                string s1 = Console.ReadLine();
                char[] ch1 = s1.ToCharArray();

                Array.Sort(ch);
                Array.Sort(ch1);
                string n1 = new string(ch);
                string n2 = new string(ch1);

                if(n1 == n2){
                    Console.WriteLine("it is anagram");

                }else
                {
                    Console.WriteLine("not anagram");
                }
                
            }
        }
    }
}
