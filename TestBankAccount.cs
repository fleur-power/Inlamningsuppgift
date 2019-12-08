using System;
using Xunit;
using Svar_8a;

namespace Svar_8a_Test
{
    public class TestBankAccount
    {

//////////---DEPOSIT---//////////

        [Fact]
        public void Deposit_ShouldReturnTrueAtSuccess()
        {
            // arrange
            double amount = 1.0;
            BankAccount account = new BankAccount();  // a zero balance at creation

            // Assert.True(account != null); ?

            // act
            bool result = account.Deposit(amount);

            // assert 
            Assert.True(result);
        }

        [Fact]
        public void Deposit_ShouldReturnFalseAtFail()
        {
            // arrange
            double amount = -1.0;                      // a forbidden value (?)
            BankAccount account = new BankAccount();

            // act
            bool result = account.Deposit(amount);

            // assert
            Assert.False(result);
        }

//////////---WITHDRAW---//////////

        [Fact]
        public void Withdraw_ShouldReturnTrueAtSuccess()
        {
            // arrange
            double amount = 1.0;
            BankAccount account = new BankAccount();

            // act
            bool result = account.Withdraw(amount);    // ensure that we have funds to withdraw

            // Assert.True(account.Deposit(amount));

            // assert
            Assert.True(result);
        }

        [Fact]
        public void Withdraw_ShouldReturnFalseAtFail()
        {
            // arrange
            double amount = -1.0;                      // a forbidden value (?)
            BankAccount account = new BankAccount();            
            
            // act            
            bool result = account.Withdraw(amount);  
            
            // assert
            Assert.False(result);  // Assert.True(!result);
        }
    } 
}
