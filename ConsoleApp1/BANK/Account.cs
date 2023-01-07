using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.BANK
{
    class Account
    {
        private int acno;
        private int useracno;

        public int Useracno { get ; set ; }

        protected string name;
        internal int deposit;
        protected internal char type;
        private void createAccount()
        {
            Console.WriteLine("\n Enter the Account no:");
            useracno = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Name of Account Holder :");
            name = Console.ReadLine();

            Console.WriteLine("\n Enter the Type Of Account(Current / Saving)");
            type = char.Parse(Console.ReadLine());

            Console.WriteLine("/n Enter the inital amount is >=500 for Saving and >=1000 for current");
            deposit = int.Parse(Console.ReadLine());

            Console.WriteLine("\n\n Account created");


        }
        public void createaccount()
        {
            createAccount();
        }
        protected void showAccount()
        {
            Console.WriteLine("\n Account No. : {0}",acno);
            Console.WriteLine("\nAccount Holder Name : {0}",name);
            
            Console.WriteLine("\nType Account: {0}",type);
           
            Console.WriteLine("\nBalance ammount: {0}",deposit);
            
        }
        public void showaccount()
        {
            showAccount();
        }
        internal void modifyAccount()
        {
            Console.WriteLine("\nAccount no. : {0}", acno);
            Console.WriteLine("\nModify Account Holder Name: ");
            name = Console.ReadLine();
            Console.WriteLine("\nModify Type Of Account : ");
            type = char.Parse(Console.ReadLine()); 
            Console.WriteLine("\nModify Balance amount :");
            deposit = int.Parse(Console.ReadLine());
        }
        public void modifyaccount()
        {
            modifyAccount();
        }
        public void accountDept()
        {
            int x;
            Console.WriteLine("Enter the amount you want to deposit::");
            x = int.Parse(Console.ReadLine());
            deposit = deposit + x;
        }
        public void accountdraw()
        {
            int x;
            Console.WriteLine("Enter the amount You want to withdraw::");
            x = int.Parse(Console.ReadLine());
            deposit = deposit - x;

        }
        public void accountReport()
        {
            Console.WriteLine("Account no::{0}\n Name :: {1} \n Type:: {2} \n Deposit ::{3}\n",acno,name,type,deposit);
        }
        public int retaccno()
        {
            return acno;
        }
        public int retdeposit()
        {
            return deposit;

        }
        public char rettype()
        {
            return type;
        }
    }
}
