﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Loop
{
    class Pattern1
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 6; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write("*");

                }
                Console.WriteLine();
            }
        }
    }
}
