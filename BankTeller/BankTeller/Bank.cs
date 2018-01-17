using System.Collections.Generic;

namespace BankTeller
{
    public class Bank
    {
        private List<Account> _accounts = new List<Account>();

        public void AddAccount(Account account)
        {
            _accounts.Add(account);
        }

        public List<Account> GetAccounts() {
            return _accounts;
        }
    }
}