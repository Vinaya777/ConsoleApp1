using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.BANK
{
    class AccessBANK : Account
    {


        static void Main(string[] args)
        {
            enumProgram banke = new enumProgram();
            int num, n;
            Data data1 = new Data();
            Account accountbank = new Account();

            data1.accessDetails();
            Console.Clear();
            data1.showStart();
            Console.WriteLine("\n Bank Active Days Are As Follow");
            Console.WriteLine("\n Active Days are follows Monday,Tuesday,Wenseday,Thursday,Friday......and Saturday /Sunday is Off ");
            Console.ReadLine();
            banke.showActiveDays();

            do
            {
                Console.WriteLine("\n\t 1. Main Menu");
                Console.WriteLine("\n 2. New Account");
                Console.WriteLine("\n 3.Withdraw");
                Console.WriteLine("\n 4.Balance enquiry");
                Console.WriteLine("\n 5.Detail Account Holder List");
                Console.WriteLine("\n 6.Modify Account");
                Console.WriteLine("\n 7.Exit");
                Console.WriteLine("\n\t Select Your Option(1-7)");
                n = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (n)
                {
                    case 1:
                        {
                            Console.WriteLine("Create Account");
                            Console.Clear();
                            data1.accessDetails();
                            accountbank.createaccount();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Deposit Money");
                            Console.Clear();
                            data1.accessDetails();
                            accountbank.accountDept();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Draw Money");
                            Console.Clear();
                            data1.accessDetails();
                            accountbank.accountdraw();
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Show the Account");
                            Console.Clear();
                            data1.accessDetails();
                            accountbank.accountReport();
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Show Account Changes");
                            Console.Clear();
                            data1.accessDetails();
                            accountbank.showaccount();
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("Enter The Account No.");
                            Console.Clear();
                            data1.accessDetails();
                            accountbank.modifyAccount();
                            break;
                        }
                }


            } while (n != 7);
        }
    
        


    }
}
