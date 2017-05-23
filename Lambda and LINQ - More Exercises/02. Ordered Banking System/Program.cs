using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Ordered_Banking_System
{
    class Program
    {
        static void Main(string[] args)
        {
            var bankAccounts = new Dictionary<string, Dictionary<string, decimal>>();
            string line = Console.ReadLine();

            while (line != "end")
            {
                string[] tokens = line.Split(new[] {' ', '-', '>'}, StringSplitOptions.RemoveEmptyEntries);
                string bankName = tokens[0];
                string accountName = tokens[1];
                decimal balance = decimal.Parse(tokens[2]);

                AddToBankAccount(bankName, accountName, balance, bankAccounts);

                line = Console.ReadLine();
            }
           bankAccounts
                .OrderByDescending(bank => bank.Value.Sum(accountName => accountName.Value))
                .ThenByDescending(bank => bank.Value.Max(account => account.Value))
                .ToList()
                .ForEach(bank => bank.Value
                .OrderByDescending(account => account.Value)
                .ToList()
                .ForEach(accountName => Console.WriteLine($"{accountName.Key} -> {accountName.Value} ({bank.Key})")));       
        }

        private static void AddToBankAccount(string bankName, string accountName,
           decimal balance, Dictionary<string, Dictionary<string, decimal>> bankAccounts)
        {
            if (!bankAccounts.ContainsKey(bankName))
            {
                bankAccounts.Add(bankName, new Dictionary<string, decimal>());
            }
            if (!bankAccounts[bankName].ContainsKey(accountName))
            {
                bankAccounts[bankName].Add(accountName, 0);
            }

            bankAccounts[bankName][accountName] += balance;
        }
    }
}
