using System;
using Microsoft.Data.Sqlite;

namespace BankTeller
{
   class Program
    {
       
        static void Main(string[] args)
        {
            // Create an instance of the database interface
            DatabaseInterface db = new DatabaseInterface();

            // Create an instance of the bankTeller object
            BankTeller bankTeller = new BankTeller(db);
            

            // Check/create the Account table
            db.CheckAccountTable();

            int choice;

            do
            {
                // Show the main menu by invoking the static method
                choice = MainMenu.Show();

                switch (choice)
                {
                    // Menu option 1: Adding account
                    case 1: {
                        // Ask user to input customer name
                        string CustomerName = Console.ReadLine();
                        int accountNumber = bankTeller.AddAccount(CustomerName);
                        break;
                    }

                    // Menu option 2: Deposit money
                    case 2: {
                        
                        Console.Clear();
                        Console.WriteLine("Enter the customer name");
                        string CustomerName = Console.ReadLine();
                        
                        // Check for an account Id, the method returns a -1 if
                        // the user does not have an account
                        int accountId = bankTeller.GetAccountNumber(CustomerName);

                        // If the customer name is not in the db then kick the teller out
                        if (accountId == -1) {
                            Console.WriteLine("No Account By That Name -- ENTER to Continue");
                            Console.ReadLine();
                            break;
                        } 

                        // Provide an initial balance
                        double balance = bankTeller.CheckBalance(accountId);
                        Console.WriteLine($"Account # is {accountId}, initial balance is {balance.ToString("C")} -- ENTER to Continue");
                        
                        // Ask for deposit amount
                        Console.WriteLine("How much would you like to deposit?");
                        double deposit = Convert.ToDouble(Console.ReadLine());

                        bankTeller.DepositMoney(deposit,accountId);
                        balance = bankTeller.CheckBalance(accountId);

                        Console.WriteLine($"New balance is {balance.ToString("C")} -- ENTER to Continue");
                        Console.ReadLine();
                        
                        break;
                    }

                    // Menu option 3: Withdraw money
                    case 3: 
                        {
                        Console.Clear();
                        Console.WriteLine("Enter the customer name");
                        string CustomerName = Console.ReadLine();
                        
                        // Check for an account Id, the method returns a -1 if
                        // the user does not have an account
                        int accountId = bankTeller.GetAccountNumber(CustomerName);

                        if (accountId == -1) {
                            Console.WriteLine("No Account By That Name -- ENTER to Continue");
                            Console.ReadLine();
                            break;
                        } 
                        // Provide an initial balance
                        double balance = bankTeller.CheckBalance(accountId);
                        Console.WriteLine($"Account # is {accountId}, initial balance is {balance.ToString("C")} -- ENTER to Continue");
                        
                        // Ask for withdrawal amount
                        Console.WriteLine("How much would you like to withdraw?");
                        double withdrawal = Convert.ToDouble(Console.ReadLine());

                        bankTeller.WithdrawMoney(withdrawal,accountId);
                        
                        balance = bankTeller.CheckBalance(accountId);
                        Console.WriteLine($"New balance is {balance.ToString("C")} -- ENTER to Continue");
                        Console.ReadLine();
                        
                        break;
                        }

                    case 4: 
                        {
                        Console.Clear();
                        Console.WriteLine("Enter the customer name");
                        string CustomerName = Console.ReadLine();
                        
                        // Check for an account Id, the method returns a -1 if
                        // the user does not have an account
                        int accountId = bankTeller.GetAccountNumber(CustomerName);

                        if (accountId == -1) {
                            Console.WriteLine("No Account By That Name -- ENTER to Continue");
                            Console.ReadLine();
                            break;
                        } 
                        
                        // Provide an initial balance
                        double balance = bankTeller.CheckBalance(accountId);
                        Console.WriteLine($"Current Account Balance for {CustomerName}");
                        Console.WriteLine($"{balance.ToString("C")}");
                        Console.WriteLine("ENTER to Continue");
                        Console.ReadLine();
                        
                        break;
                    }
                }
            } while (choice != 5);



        }

    }
}
