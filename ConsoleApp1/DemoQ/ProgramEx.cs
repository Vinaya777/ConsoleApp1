using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DemoQ
{
    class ProgramEx
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();

            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);


            queue.Dequeue();

            Console.WriteLine("first element in queue " + queue.Peek());

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

        }
    }
}
