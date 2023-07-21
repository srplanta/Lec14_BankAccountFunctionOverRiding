using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class BankAccountRepository
    {
        BankAccount[] bankAccounts;
        int index;

        public BankAccountRepository()
        {
            bankAccounts = new BankAccount[10];
            index = -1;
        }

        public void CreateBankAccount()
        {
            if (index < 10)
            {
                if (index == -1)
                {
                    index = 0;
                }
                var bankAccount = new CurrentAccount("Ali Khan", 500M);
                bankAccounts[index] = bankAccount;
                index++;
                Console.WriteLine("Bank account created successfully");
            }
            else
            {
                Console.WriteLine("Oops! All locations are occupied.");
            }
        }

        public void DisplayBankAccounts()
        {
            if (index > -1)
            {
                for (int i = 0; i < index; i++)
                {
                    Console.WriteLine(bankAccounts[i].ToString());
                }
            }
            else
            {
                Console.WriteLine("Oops! no record found.");
            }
        }

        public void CashDeposit()
        {
            Console.Write("Please enter amount to deposit:\t");
            var depositAmount = Convert.ToDecimal(Console.ReadLine());
            bankAccounts[0].Deposit(depositAmount);
            Console.WriteLine("Amount deposited Successfully.");
            Console.WriteLine(bankAccounts[0]);
        }

        public void CashWithdraw()
        {
            try
            {
                Console.Write("Please enter amount to Withdraw:\t");
                var withdrawAmount = Convert.ToDecimal(Console.ReadLine());
                bankAccounts[0].Withdraw(withdrawAmount);
                Console.WriteLine("Amount Withdraw Successfully.");
                Console.WriteLine(bankAccounts[0]);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Oops! something went wrong.\n" +
                    "Try again please.");
            }
            //Console.WriteLine(ex.ToString()); }
        }

        public void CompareBankAccounts()
        {
            var bankAccount1 = new CurrentAccount("Ali Khan", 500M);
            var bankAccount2 = new CurrentAccount("Ali Khan", 500M);

            //var result = bankAccount1.Equals(bankAccount2);
            if (bankAccount1.Equals(bankAccount2))
            {
                Console.WriteLine("Both bank accounts are same.");
            }
            else
            {
                Console.WriteLine("Both bank accounts are not same");
            }
        }
    }
}
