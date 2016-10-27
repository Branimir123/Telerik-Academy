namespace BankAccounts
{
    using BankAccounts.Contracts;
    using BankAccounts.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        static void Main()
        {
            //Testing our bank system: 

            //Creating list of different accounts
            var accounts = new List<IAccount>{
                new DepositAccount(CustomerType.Individual, 1500.545M, 3.5M),
                new LoanAccount(CustomerType.Company, 5600.345M, 3.0M), 
                new MortgageAccount(CustomerType.Individual, 3500.89M, 3.5M)
            };
            //Creating a bank
            var bank = new Bank(accounts);
            //Testing bank add method
            bank.AddAccount(new MortgageAccount(CustomerType.Individual, 34534.45M, 44.5M));

            //Sorting by balance
            bank.Accounts = bank.Accounts.OrderBy(s => s.Balance).Select(s => s).ToList();
            foreach (var acc in bank.Accounts)
            {
                Console.WriteLine(acc.Balance);
            }

            //Get all accounts held by individuals
            var individuals = bank.Accounts.Where(s => s.Customer == CustomerType.Individual).Select(s => s).ToList();
          
            //Collect their intherests for N months
            int months = 5;

            var interests = new List<decimal>();
            foreach (var ind in individuals)
            {
                interests.Add(ind.CalculateInterest(months));
            }
            //Printing the interests
            foreach (var intr in interests)
            {
                Console.WriteLine(intr.ToString());
            }

        }
    }
}
