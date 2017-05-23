using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Optimized_Banking_System
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            var accountsList = new List<BankAccount>();

            while (line != "end")
            {
                BankAccount currentAccount = new BankAccount();
                currentAccount = currentAccount.CreateAccount(line);
                accountsList.Add(currentAccount);
                

                line = Console.ReadLine();
            }
            //accountsList.Sort(p => p.Name);

            accountsList = new List<BankAccount>(accountsList
                .OrderByDescending(p => p.Balance)
                .ThenBy(p => p.Bank.ToCharArray().Length));
            //accountsList.OrderByDescending(p => p.Balance).ThenBy(p => p.Bank.ToCharArray().Length);



            foreach (var list in accountsList)
            {
                Console.WriteLine($"{list.Name} -> {list.Balance} ({list.Bank})");
            }

        }
    }
}
