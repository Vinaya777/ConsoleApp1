using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.StringEx
{
    class Toggle
    {
        public void toggleCase(String sc)
        {
            char[] c = sc.ToCharArray();
            
                for (int i = 0; i < c.Length; i++)
                {
                    if (c[i] >= 'a' && c[i] <= 'z')
                    {
                        c[i] = (char)(c[i] - 32);
                    }
                    else if (c[i] >= 'A' && c[i] <= 'Z')
                    {
                        c[i] = (char)(c[i] + 32);
                    }
                }

            
                String str = new String(c);
                Console.WriteLine("Toggle case of each character of a string " + str);
                Console.ReadLine();

            }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the String:");
            String sc = Console.ReadLine();

            Toggle o = new Toggle();
            o.toggleCase(sc);
        }
    }
}
