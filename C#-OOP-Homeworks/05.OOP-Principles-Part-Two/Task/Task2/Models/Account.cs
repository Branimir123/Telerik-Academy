namespace BankAccounts.Models
{
    using BankAccounts.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class Account : IAccount, IDepositable
    {
        public Account(CustomerType customer, decimal balance, decimal interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }
        public CustomerType Customer { get; set; }
        public decimal Balance { get; set; }
        public decimal InterestRate { get; set; }
        public virtual void Deposit(decimal money)
        {
            this.Balance += money;
        }
        public virtual decimal CalculateInterest(int months)
        {
            return months * this.InterestRate;
        }
    }
}
