namespace BankAccounts.Models
{
    using BankAccounts.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Bank : IBank
    {
        public Bank(ICollection<IAccount> accounts)
        {
            this.Accounts = accounts; 
        }
        public ICollection<IAccount> Accounts { get; set; }

        public void AddAccount(IAccount account)
        {
            this.Accounts.Add(account);
        }
        public void RemoveAccount(IAccount account)
        {
            this.Accounts.Remove(account);
        }
    }
}
