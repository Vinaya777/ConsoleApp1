using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ExtensionAndPartialMethod
{
   public partial class Calculation
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Sub(int a, int b)
        {
            return a - b;
        }

        partial void Square(int a);
        public void HelperMethod(int a)
        {
            Square(a);
        }
    }
}
