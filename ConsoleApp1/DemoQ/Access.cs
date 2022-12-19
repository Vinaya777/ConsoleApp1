using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DemoQ
{
    class Access
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();
            Queue[] aq = new Queue[]
            {
              new Queue()
              {
                  
              }
              
            };
            q.Enqueue(25);
            q.Enqueue(10);
            q.Enqueue(20);
            q.Enqueue(30);
            
            Console.ReadLine();

            q.Dequeue();
            Console.WriteLine("first element in queue " + q.Peek());

            foreach (var item in q)
            {
                Console.WriteLine(item);
            }


        }
    }
}
