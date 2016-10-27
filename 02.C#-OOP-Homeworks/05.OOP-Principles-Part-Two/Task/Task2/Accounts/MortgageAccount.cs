using BankAccounts.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts.Models
{
    public class MortgageAccount : Account
    {
        public MortgageAccount(CustomerType customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        { }
        public override decimal CalculateInterest(int months)
        {
            if (this.Customer == CustomerType.Individual)
            {
                return (months * this.InterestRate) - (6 * this.InterestRate);
            }
            else
            {
                return (months * this.InterestRate) - (12 * this.InterestRate / 2);
            }
        }
    }
}
