
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.NewItem
{
    class ArrayListUniqueElt
    {
       


        static void Main(string[] args)
        {
            String[] str = { "sun", "mon", "sun", "tue", "wed", "mon" };
           
            List<String> al = new List<string>(str);
        
            foreach(var i in al)
            {
                Console.WriteLine(al);


            }
            ArrayListUniqueElt all = new ArrayListUniqueElt();
            al.Count.ToString();
            al.RemoveAt(0);
            al.Insert(2, "Abc");
            al.AddRange(str);

        }
    }
}
