using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public abstract class BankAccount
    {
        public BankAccount()
        {
            DateCreated = DateTime.Now;
        }

        public BankAccount(string _title) : this()
        {
            Title = _title;
        }

        public BankAccount(string _title, decimal _openingBalance, AccountType _accountType) : this(_title)
        {
            OpeningBalance = _openingBalance;
            CurrentBalance = _openingBalance;
            AccountType = _accountType;
        }
        public string Title { get; private set; }
        public decimal OpeningBalance { get; private set; }
        public decimal CurrentBalance { get; private set; }
        public DateTime DateCreated { get; private set; }
        public AccountType AccountType { get; private set; }

        public virtual void Deposit(decimal _depositAmount)
        {
            CurrentBalance += _depositAmount;
        }

        public virtual void Withdraw(decimal _withdrawAmount)
        {
            if (_withdrawAmount > CurrentBalance)
            {
                throw new InvalidOperationException("Oops! Amount exceeds account balance.");
            }
            CurrentBalance -= _withdrawAmount;
            Console.WriteLine($"Current balance is {CurrentBalance}");
        }

        public override string ToString()
        {
            return $"Account Title:\t\t{Title}\n" +
                $"Opening Balance:\t{OpeningBalance}\n" +
                $"Current Balance:\t{CurrentBalance}\n" +
                $"Date Created:\t\t{DateCreated}\n" +
                $"AccountType:\t\t{AccountType}\n" +
                $"------------------------------------";
        }

        public override bool Equals(object? obj)
        {
            var paramBankAccount = obj as BankAccount;
            if (paramBankAccount.Title == this.Title)
            {
                return true;
            }
            return false;
        }

        public abstract void SystemAlert();
    }
}
