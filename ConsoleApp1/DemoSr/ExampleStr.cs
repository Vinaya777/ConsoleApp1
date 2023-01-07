using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//String -immutable namespace System //intern pool ,== overloaded it compares data ,object.ReferenceEquals(ob1,ob2)
//StringBuilder-mutable ,namespace System.text ,== compare references


//Nullable types
//?? -null coalescing 
//params -is take variable number of arguments
//tuples
//Datetime
namespace ConsoleApp1.DemoSr
{
    class ExampleStr
    {
        static void add(int a, int b = 0)
        {
            Console.WriteLine(a + b);
        }
        static void add(params int[] a)
        {
            int sum = 0;
            foreach (int d in a)
            {
                sum = sum + d;
            }
            Console.WriteLine("summm=" + sum);
        }

        static void Main2(string[] args)
        {
            add(1, 2, 3, 4, 5, 6, 7, 8);
        }
        static void Main1(string[] args)
        {
            StringBuilder sb = new StringBuilder("Think");
            StringBuilder sb2 = new StringBuilder("think");
            Console.WriteLine(sb == sb2);
            Console.WriteLine(sb.Equals(sb2));
            Console.WriteLine(sb.Capacity);//16
            Console.WriteLine(sb.Length);//5
            StringBuilder ss = sb.Append("Quotient");
            sb.Append(1234);
            sb.AppendLine();
            sb.Append("C#");
            Console.WriteLine(sb == ss);
            Console.WriteLine(sb);
            sb.Insert(5, "Software");
            Console.WriteLine(sb);
            sb.Remove(2, 3);
            Console.WriteLine(sb);
            sb.Replace('o', 'O');
            Console.WriteLine(sb);



            //int i = null;
            Nullable<int> i = 80;

            if (i.HasValue)
                Console.WriteLine("yes" + i.Value);
            else
                Console.WriteLine("no");

            int? x = 900;
            long? mb = 3543545;
            int z = x.GetValueOrDefault();
            Console.WriteLine("z=" + z);

            //?? null coalescing 
            int? age = 25;
            int m = age ?? 18;
            Console.WriteLine("Age=" + m);



        }
    }

    class TuplesDemo
    {
        static int calculator(int a, int b)
        {
            int sum = a + b;
            return sum;
        }
        static void m1(dynamic obj)
        {
            Console.WriteLine("Id " + obj.Item1);
            Console.WriteLine("name " + obj.Item2);
        }

        static Tuple<int, int> m2(int a, int b)
        {
            int s = a + b;
            int d = a - b;
            return Tuple.Create(s, d);
        }

        static (int total, int difference, int multiply) m3(int a, int b)
        {
            int s = a + b;
            int d = a - b;
            int prod = a * b;
            return (s, d, prod);
        }
        static void Main(string[] args)
        {

            //unpacking tuple
            var (sum, diff, product) = m3(10, 20);
            Console.WriteLine(sum);
            Console.WriteLine(diff);
            Console.WriteLine(product);

            var t1 = m3(10, 20);
            Console.WriteLine(t1.Item1);
            Console.WriteLine(t1.Item2);
            Console.WriteLine(t1.Item3);

            var t2 = m3(10, 20);
            Console.WriteLine(t2.total);
            Console.WriteLine(t2.difference);
            Console.WriteLine(t2.multiply);






            Tuple<int, String> ob = Tuple.Create(1, "Riya");
            //Console.WriteLine(ob.Item1);
            /* m1(ob);
             Tuple<int, int> obb = m2(100,50);
             Console.WriteLine(obb.Item1);
             Console.WriteLine(obb.Item2);
 */
            /*Console.WriteLine(ob.Item2);
            int add=calculator(10, 20);
            Console.WriteLine(add);
        */

            DateTime dt = new DateTime(2021, 11, 11);
            DateTime dt2 = DateTime.Today;
            Console.WriteLine(dt2 - dt);
            Console.WriteLine(dt2.Month);
            Console.WriteLine(dt2.Year);
            Console.WriteLine(dt2 > dt);
            /*Console.WriteLine(dt2);
            DateTime dt3 = DateTime.Today;
            Console.WriteLine(dt3);*/
        }
    }
}
