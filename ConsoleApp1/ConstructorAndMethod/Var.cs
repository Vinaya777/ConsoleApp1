using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ConstructorAndMethod
{
    /*class Var
    {
        static void Main(string[] args)
        {
            var varInt= 100;
            var varChar = 'A';
            var varString = "abcdefg";

            Console.WriteLine($"{0}\n {1}\n{2}",varInt,varChar,varString);
            Console.ReadLine();
        }
    }*/
}
class Params
{
    public void Show(params int[] num)
    {
        for(int a=0; a < num.Length; a++)
        {
            Console.WriteLine(num[a]);
        }

    }
    static void Main(string[] args)
    {
        Params pr = new Params();
        pr.Show(20, 30, 60, 40, 50);
        Console.ReadLine();
    }
}



