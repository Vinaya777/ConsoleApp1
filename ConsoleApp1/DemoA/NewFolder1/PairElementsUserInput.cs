using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DemoA.NewFolder1
{
    class PairElementsUserInput
    {
        public void acceptArray1Elts(int[] s)
        {
            Console.WriteLine("Enter the Array Vlaues");
            for(int i = 0; i < s.Length; i++)
            {
                s[i] = int.Parse(Console.ReadLine());
            }
        }
        int n;
        public void PairWhoseSumIsGivenInt(int[] s)
        {
            for(int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j <s.Length; i++)
                {
                    if (n == s[i] + s[j])
                    {
                        Console.WriteLine($"({s[i]},{s[j]})");
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Size Of Array");
            int a = int.Parse(Console.ReadLine());
            int[] s = new int[a];
           // int[] b = { 52, 35, 65, 85, 95 };
            PairElementsUserInput Peu = new PairElementsUserInput();
            Peu.PairWhoseSumIsGivenInt(s);
            Peu.acceptArray1Elts(s);
            
            

        }
    }
}
