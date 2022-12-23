using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1._15thdec.Bank_Projrct
{

    public enum AccountType { SAVINGS,CURRENT };
    class Bank
    {


        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>()
            {
                new Customer (){
                    name ="Vinaya" , accounts = new List<Account>(){ 
                    new Account(){ accounttype = AccountType.SAVINGS , acctno = 1 ,loanType = "Car"},
                    new Account(){ accounttype = AccountType.CURRENT , acctno = 2 ,loanType = "Gold"}
                    }
                },new Customer (){
                    name ="dewa" , accounts = new List<Account>(){
                    new Account(){ accounttype = AccountType.SAVINGS , acctno = 3 ,loanType = "Home"},
                    new Account(){ accounttype = AccountType.CURRENT , acctno = 4 ,loanType = "Personal"},
                    new Account(){ accounttype = AccountType.SAVINGS , acctno = 5 ,loanType = "Mutual Fund"}
                    }
                },new Customer (){
                    name ="rajvi" , accounts = new List<Account>(){
                    new Account(){ accounttype = AccountType.SAVINGS , acctno = 5 ,loanType = "Home"},
                    new Account(){ accounttype = AccountType.CURRENT , acctno = 7 ,loanType = "Personal"},
                    new Account(){ accounttype = AccountType.SAVINGS , acctno = 8 ,loanType = "Mutual Fund"}
                    }
                }
            };
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.name);
                foreach (var account in customer.accounts)
                {

                    Console.WriteLine($"Account Number: {account.acctno},Account Type:{account.accounttype},Account LoanType:{account.loanType}");
                    /*Console.WriteLine(account.acctno);
                    Console.WriteLine(account.accounttype);
                    Console.WriteLine(account.loanType);*/
                }
                
            }

            Console.ReadLine();

        }
    }
}
