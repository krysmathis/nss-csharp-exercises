using System;
using Xunit;

namespace BankTeller.Tests
{
    public class TellerShould
    {
        DatabaseInterface db = new DatabaseInterface();

        [Fact]
        public void AddAccount() {

            BankTeller teller = new BankTeller(db);
            string customerName = "Test Account";

            // Add Account
            int accountNumber = teller.AddAccount(customerName);
            // Verify
            Assert.True(accountNumber > -1);

            // Remove Account as part of clean-up
            teller.RemoveAccount(customerName);
            accountNumber = teller.GetAccountNumber(customerName);
            Assert.Equal(-1 ,accountNumber);
        }

        [Fact]
        public void DepositMoney() {
            
            BankTeller teller = new BankTeller(db);
            double money = 100;
            double balance = teller.CheckBalance(5);
            teller.DepositMoney(money,5);    
            double newBalance = teller.CheckBalance(5);

            Assert.Equal(money + balance, newBalance);
            
        } 

        [Fact]
        public void WithdrawMoney() {
            
            BankTeller teller = new BankTeller(db);
            double money = 100;
            double balance = teller.CheckBalance(5);
            teller.WithdrawMoney(money,5);    
            double newBalance = teller.CheckBalance(5);

            Assert.Equal(balance - money, newBalance);
        } 
        
        [Fact]
        public void ShowAccountBalance() {
             
             BankTeller teller = new BankTeller(db);
             int accountId = 6;
             double balance = teller.CheckBalance(accountId);

             Assert.Equal(balance, 200);
        }

        
        [Fact]
        public void GetAccountNumber() {
             
            string customer = "Jevon Smith";
            
            BankTeller teller = new BankTeller(db);
            int accountNumber = teller.GetAccountNumber(customer);

            Assert.Equal(4,accountNumber);
        }
        
    }
}
