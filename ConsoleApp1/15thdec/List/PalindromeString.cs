﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1._15thdec.List
{
    class PalindromeString
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string to Check Palindrome : ");
            string name = Console.ReadLine();
            string reverse = string.Empty;

            for (int i = name.Length - 1; i >= 0; i--)
            {
                reverse += name[i];
            }

            if (name == reverse)
            {
                Console.WriteLine($"{name} is Palindrome.");
            }
            else
            {
                Console.WriteLine($"{name} is not Palindrome");
            }
            Console.ReadKey();
        }
    }
}
