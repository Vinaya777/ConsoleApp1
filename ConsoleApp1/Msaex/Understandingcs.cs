using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Stack
{
    class Understandingcs
    {
        int top;
        int size;
        int[] arr;
        public Understandingcs(int size)
        {
            top = -1;
            this.size = size;
            arr = new int[size];
        }
        public void push(int data)
        {
            if (top < arr.Length - 1)
            {
                arr[++top] = data;
                Console.WriteLine(arr[top] + " pushed. top at " + top);
            }
            else
            {
                Console.WriteLine("Stack is Full");
            }
        }
        public void pop()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is Empty");
            }
            else
            {
                arr[top] = 0;
                top--;
                Console.WriteLine("Element popped out.");
            }
        }

        public int peek()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is Empty");
                return -1;
            }
            else
            {
                return arr[top];
            }
        }
        public void ShowStack()
        {
            Console.WriteLine("Stack Elements are..............");
            if (top > -1)
            {
                for(int i = top; i > -1; i--)
                {
                    Console.WriteLine(arr[i] + " ");
                }
            }
            else
            {
                Console.WriteLine("Stack IS Empty...!!!!!!!!!!!!!!!!!");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {

        }
    }
}
