namespace BankAccounts.Contracts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using BankAccounts.Models;

    public interface IAccount
    {
        CustomerType Customer { get; set; }
        decimal Balance { get; set; }
        decimal InterestRate { get; set; }
        void Deposit(decimal money);
        decimal CalculateInterest(int months);
    }
}
