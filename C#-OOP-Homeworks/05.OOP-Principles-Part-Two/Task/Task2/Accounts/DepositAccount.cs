namespace BankAccounts.Models
{
    using BankAccounts.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class DepositAccount : Account, IWithdrawable
    {
        public DepositAccount(CustomerType customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        { }
        public void Withdraw(decimal money)
        {
            this.Balance -= money;
        }

        public override decimal CalculateInterest(int months)
        {
            if (this.Balance > 0 && this.Balance <= 1000)
            {
                this.InterestRate = 1;
            }
            return months * this.InterestRate;
        }
    }
}
