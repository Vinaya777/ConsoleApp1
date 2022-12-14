using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ExtensionAndPartialMethod
{
   public partial class Calculator
    {
        public int Multiply(int a, int b)
        {
            return a * b;
        }
        public double Div(int a, int b)
        {
            return (double)a / b;
        }

        /*partial void Square(int a)
        {
            Console.WriteLine(a * a);
        }*/
       public float Square(int a)
        {
            return (float) a;
            
        }
    }

   
       /* static void Main(string[] args)
        {
            Caclulation c = new Caclulation();
            c.Add(1, 2);
           // c.Multiply(3, 4);
            c.HelperMethod(2);
        }*/
    }


