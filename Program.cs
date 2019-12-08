using System;

namespace Svar_8a
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            BankAccount account = new BankAccount();
            account.Deposit(500);   // true
            account.Withdraw(1000); // false, finns inte så mycket pengar på kontot         
        }
    }
}
