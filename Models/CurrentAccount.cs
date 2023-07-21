using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class CurrentAccount : BankAccount
    {
        private decimal transactionTax;
        public CurrentAccount(string _title, decimal _openingBalancd) : base(_title, _openingBalancd, AccountType.SavingsAccount)
        {
            transactionTax = 200M;
        }

        public override void Deposit(decimal _depositAmount)
        {
            base.Deposit(_depositAmount - transactionTax);
        }

        public override void Withdraw(decimal _withdrawAmount)
        {
            base.Withdraw(_withdrawAmount - transactionTax);
        }

        public override string ToString()
        {
            return base.ToString() + $"Tax rate is {transactionTax}";
        }

        public override void SystemAlert()
        {
            //throw new NotImplementedException();
            Console.Write("Alert from system");
        }
    }
}
