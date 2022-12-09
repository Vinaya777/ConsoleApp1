using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.InheritanceAndPolymorphism
{
    public class ApplicationPayroll
    {
        protected int grossincome;
        protected int grossdeduction,netpayment;
        protected String name;

        public ApplicationPayroll(int income,int gross,int netpayment)
        {
            this.grossincome = income;
            this.grossdeduction = gross;
            this.netpayment = netpayment;
           


        }
        public virtual void Salary()
        {
            netpayment = grossincome - grossdeduction;
        }
        public override string ToString()
        {
            return $"Income{grossincome},Deduction{grossdeduction},NetPayment{netpayment},NAme{name}";
        }
    }

    public class OnlinePayroll: ApplicationPayroll
   {
         int salary;
         int compliance;
        
        public OnlinePayroll(int income, int gross, int netpayment, int salary,int compliance) : base (income,gross,netpayment)
        {
            this.salary = salary;
            this.compliance = compliance;
        }
        public virtual void SalaryOnline()
        {
            Salary();
            netpayment = grossincome - grossdeduction+salary+compliance;
        }
        public override string ToString()
        {
            return $"OnlinePayroll Salary{salary},Compliance{compliance}";
        }

    }
    public class PayrollAccounting: ApplicationPayroll
    {
        private int variablePay;
        public PayrollAccounting(int income, int gross, int netpayment, int salary, int compliance, int variablePay):base(income, gross, netpayment)
        {
            this.variablePay = variablePay;

        }
        public virtual void PayslipCalculation()
        {
            netpayment = (grossincome - grossdeduction ) - variablePay;
        }

        public override string ToString()
        {
            return $"PaySlip{netpayment}";
        }
    }
}