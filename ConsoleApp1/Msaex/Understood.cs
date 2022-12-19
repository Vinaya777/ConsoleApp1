using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Stack
{
    class Understood
    {
        static void Main(string[] args)
        {
            Understandingcs us = new Understandingcs(5);

			us.push(76);
			us.push(4);
			us.ShowStack();

			us.push(986);
			us.push(84);
			us.push(176);
			
			us.push(4);

			int val = us.peek();
			Console.WriteLine("\nLatest value peeked is " + val);

			us.pop();
			us.ShowStack();
			Console.ReadLine();
		}
    }
}
