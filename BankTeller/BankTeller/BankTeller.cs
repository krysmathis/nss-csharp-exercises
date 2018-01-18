using System;
using System.Linq;
using Microsoft.Data.Sqlite;

namespace BankTeller
{
    public class BankTeller
    {
        DatabaseInterface db;

        public BankTeller(DatabaseInterface databaseInterface) {
            db = databaseInterface;
        }

        public int AddAccount(string customerName) 
        {
            if (customerName.Length > 0) {
                    
            // Insert customer account into database
                return db.Insert($@"
                    INSERT INTO Account
                    (Id, Customer, Balance)
                    VALUES
                    (null, '{customerName}', 0)
                ");
            }

            return -1;
             
        }

        public void RemoveAccount(string customerName) 
        {
            db.Update($@"DELETE  
                        FROM Account
                        WHERE 
                        Customer = '{customerName}';");
        }


        public void DepositMoney(double deposit, int accountId)
        {
            db.Update($@"UPDATE Account
                        SET Balance = Balance + {deposit}
                        WHERE 
                        Id = {accountId};");
        }

        public void WithdrawMoney(double withdrawal, int accountId)
        {
             db.Update($@"UPDATE Account
                        SET Balance = Balance - {withdrawal}
                        WHERE 
                        Id = {accountId};");
        }

        public double CheckBalance(int accountId) {

            double balance = 0;
            db.Query($@"SELECT Balance FROM Account WHERE Id='{accountId}';",
                (SqliteDataReader reader) => 
                {
                    while (reader.Read ())
                    {
                        balance = reader.GetDouble(0);
                    }
                }
            );
            return balance;
        }

        public int GetAccountNumber(string customer)
        {
            int AccountId = -1;

            db.Query($@"SELECT Id FROM Account WHERE Customer='{customer}';",
                (SqliteDataReader reader) => 
                {
                    while (reader.Read ())
                    {
                        AccountId = reader.GetInt32(0);
                    }
                }
            );

            return AccountId;
        }
    }
}