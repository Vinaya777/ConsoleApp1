using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ExtensionAndPartialMethod
{
    class Ticket
    {

        public enum Ticket1
        {
            SILVER = 150, GOLD = 250, PLATINUM = 350, PIME = 480 }
            int rate;
    
        public int Rate { get =>this.rate; set => this.rate = value; }

       // private Ticket1() { }
       /* private Ticket1(int val)
        {
            Rate = val;
           
        }*/
        void ShowMessage()
        {
            Console.WriteLine("Boook your ticket through BookMyShow.com");
        }

        static void Main(string[] args)
        {
            Ticket tkts = new Ticket();
           
        }
    }
}

