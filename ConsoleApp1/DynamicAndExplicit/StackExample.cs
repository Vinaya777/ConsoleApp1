using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DynamicAndExplicit
{
    class StackExample
    {
        private dynamic data;
        public dynamic Element { get; set; }

        static dynamic Test()
        {
            return "ABC";
        }
        static void Main(string[] args)
        {
           /* float a = 1.5f;
            int b = (int)a; //explicit type casting
            int c = Convert.ToInt32(a);
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine(d);*/  //explicit tyep casting
            short s = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(s);
            int e = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(e);
            long l = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine(l);
            float f = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine(f);
            double db = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(db);
            
        }
    }
}
