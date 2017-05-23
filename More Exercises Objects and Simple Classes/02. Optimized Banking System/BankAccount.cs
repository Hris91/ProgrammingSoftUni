using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Optimized_Banking_System
{
    class BankAccount
    {
        public string Name { get; set; }
        public string Bank { get; set; }
        public decimal Balance { get; set; }

        public BankAccount CreateAccount(string line)
        {
            string[] tokens = line.Split(new[] {' ', '|'}, StringSplitOptions.RemoveEmptyEntries).ToArray();

            BankAccount currentAccount = new BankAccount()
            {
                Name = tokens[1],
                Bank = tokens[0],
                Balance = decimal.Parse(tokens[2])
            };
            return currentAccount;
        }
    }
}
