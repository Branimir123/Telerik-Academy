using BankAccounts.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts.Models
{
    public class LoanAccount : Account
    {
        public LoanAccount(CustomerType customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        { }
        public override decimal CalculateInterest(int months)
        {
            if (this.Customer == CustomerType.Individual)
            {
                return (months - 3) * this.InterestRate;
            }
            else
            {
                return (months - 2) * this.InterestRate;
            }
        }
    }
}
