// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using Infrastructure;

bool isTerminate = false;
BankAccountRepository bankAccountRepository = new BankAccountRepository();
while (!isTerminate)
{
    Console.WriteLine("Welcome to Portal");
    Console.WriteLine("Press 1) to create new account");
    Console.WriteLine("Press 2) to list all accounts");
    Console.WriteLine("Press 3) to compare accounts");
    Console.WriteLine("Press 4) to deposit amount");
    Console.WriteLine("Press 5) to withdraw amount");
    Console.WriteLine("Press 6) to terminate");
    var userInput = Console.ReadLine();
    //var input = Console.ReadLine();

    switch (userInput)
    {
        case "1":
            bankAccountRepository.CreateBankAccount();
            break;
        case "2":
            bankAccountRepository.DisplayBankAccounts();
            break;
        case "3":
            bankAccountRepository.CompareBankAccounts();
            break;
        case "4":
            bankAccountRepository.CashDeposit();
            break;
        case "5":
            bankAccountRepository.CashWithdraw();
            break;
        case "6":
            Console.WriteLine("Terminating Program");
            isTerminate = true;
            break;
        default:
            break;
    }
}
