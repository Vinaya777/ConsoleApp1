using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Delegates
{
    public delegate void MyDel();

    public class BankAc
    {
        private double acbalance;
        public event MyDel InBal;
        public event MyDel Zero;
        public BankAc(double acbalance)
        {
            this.acbalance = acbalance;
        }

        public void Debit(double amt)
        {
            if (amt > acbalance)
            {
                InBal();
            }
            else
            {
                acbalance -= amt;
                if (acbalance == 0)
                {
                    Zero();
                }
            }
        }
        public void Credit(double amt)
        {
            acbalance += amt;
        }
        public override string ToString()
        {
            return $"Current balance is {acbalance}";
        }

    }
    public static class Message1
    {
        public static void InsufficientBalance()
        {
            Console.WriteLine("Insufficient Balance to withdraw");
        }
        public static void ZeroBalance()
        {
            Console.WriteLine("Cureent Account balance is Zero");
        }
        static void Main(string[] args)
        {
            BankAc b1 = new BankAc(5000);
            b1.InBal += new MyDel(Message1.InsufficientBalance);
            b1.Zero += new MyDel(Message1.ZeroBalance);
            Console.WriteLine("Credit of 1000");
            b1.Credit(1000);
            Console.WriteLine(b1);
            Console.WriteLine("Debit 15000");
            b1.Debit(15000);
            Console.WriteLine(b1);
            Console.WriteLine("debit 6000");
            b1.Debit(6000);
            Console.WriteLine(b1);

        }
    }
    

}