using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _01.Register_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            var dateAndUsers = new Dictionary<string, DateTime>();
            string line = Console.ReadLine();

            while (line != "end")
            {
                string[] tokens = line.Split(new[] {'-', '>', ' '}, StringSplitOptions.RemoveEmptyEntries);
                string user = tokens[0];
                string dateConversion = tokens[1];
                DateTime date = DateTime.ParseExact(dateConversion, "dd/MM/yyyy", CultureInfo.InvariantCulture);

                dateAndUsers[user] = date;

                line = Console.ReadLine();
            }
            var newDate = dateAndUsers
                .Reverse()
                .OrderBy(d => d.Value)              
                .Take(dateAndUsers.Count > 5 ? 5 : dateAndUsers.Count)
                .OrderByDescending(d => d.Value)
                .ToDictionary(p => p.Key, p => p.Value);
                           
            foreach (var user in newDate.Keys)
            {
                Console.WriteLine($"{user}");
            }
        }
    }
}
