using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Winning_Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tickets = Console.ReadLine()
                .Split(',')
                .Select(p => p.Trim())
                .ToArray();

           
            string patternWinningTicket = @"([$#^@])\1{5,}";
          
            Regex winningTicketRegex = new Regex(patternWinningTicket);

            foreach (var ticket in tickets)
            {
                bool isValid = ticket.Length == 20;

                string firstHalf = ticket.Substring(0, ticket.Length  / 2);
                string secondHalf = ticket.Substring(ticket.Length / 2);
               
                bool isFirstHalfLegit = winningTicketRegex.IsMatch(firstHalf);
                bool isSecondHalfLegit = winningTicketRegex.IsMatch(secondHalf);

                Match matchFirstHalf = winningTicketRegex.Match(firstHalf);
                Match matchSecondHalf = winningTicketRegex.Match(secondHalf);

                string firstHalfSymbols = matchFirstHalf.ToString();
                string secondHalfSymbols = matchSecondHalf.ToString();

                if (!isValid)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }
                else if (!matchFirstHalf.Success || !matchSecondHalf.Success)
                {
                    Console.WriteLine($"ticket \"{ticket}\" - no match");
                    continue;                 
                }
                else
                {
                    int shorterString = Math.Min(firstHalfSymbols.Length, secondHalfSymbols.Length);
                 
                    if (firstHalfSymbols.Length == 10 && secondHalfSymbols.Length == 10)

                    {
                        Console.WriteLine($"ticket \"{ticket}\" - {firstHalfSymbols.Length}{firstHalfSymbols[0]} Jackpot!");
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - {shorterString}{firstHalfSymbols[0]}");
                    }
                }
              
            }
        }
    }
}
