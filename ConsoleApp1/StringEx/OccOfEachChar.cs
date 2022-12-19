using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.StringEx
{
    class OccOfEachChar
    {

        public void OccOfEach(char[] ch)
        {
            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i] == '*')
                    continue;
                int count = 1;
                for (int j = i + 1; j < ch.Length; j++)
                {
                    if (ch[i] == ch[j])
                    {
                        count++;
                        ch[j] = '*';
                    }
                }
                Console.WriteLine(ch[i] + "appears" + count + "times");
            }


        }
            static void Main(string[] args)
        {
            Console.WriteLine("Enter the String: ");
            String s = Console.ReadLine();
            char[] ch = s.ToCharArray();
            OccOfEachChar o = new OccOfEachChar();
            o.OccOfEach(ch);
            Console.ReadLine();

        }
    }
}