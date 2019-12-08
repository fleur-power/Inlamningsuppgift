using System;
using System.Collections.Generic;
using System.Text;

namespace Svar_8a
{
    public class BankAccount
    {
        private double balance = 0;
        public double GetBalance() { return this.balance; }
        public bool Deposit(double amount) { return false; }
        public bool Withdraw(double amount) { return false; }
    }
}
