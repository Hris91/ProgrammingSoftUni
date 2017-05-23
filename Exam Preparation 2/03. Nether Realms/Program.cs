using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


namespace _03.Nether_Realms
{
    class Program
    {
        static void Main(string[] args)
        {
            string healthPattern = @"[^0-9.+\-*/\s]+";           
            string damagePattern = @"(-?\d\.?\d+)|(-?\d)";
            string multiplyPatetrn = @"\*";
            string dividePattern = @"\/";

            string[] demonStrings = Console.ReadLine()
                .Split(new[] {',', ' '}, StringSplitOptions.RemoveEmptyEntries)
                .OrderBy(p => p)
                .ToArray();

            Regex health = new Regex(healthPattern);
            Regex damage = new Regex(damagePattern);
            Regex multiplyRegex = new Regex(multiplyPatetrn);
            Regex divideRegex = new Regex(dividePattern);

            List<Demon> demonList = new List<Demon>();

            foreach (var demon in demonStrings)
            {
                MatchCollection matchesHealth = health.Matches(demon);
                MatchCollection matchesDamage = damage.Matches(demon);
                MatchCollection matchesMultiply = multiplyRegex.Matches(demon);
                MatchCollection matchesDivide = divideRegex.Matches(demon);

                long totalHealth = CalculateHealth(matchesHealth);
                decimal totalDamage = CalculateDamage(matchesDamage, matchesMultiply, matchesDivide);

                Demon currentDemon = new Demon();
                currentDemon.Name = demon.ToString();
                currentDemon.Health = totalHealth;
                currentDemon.Damage = totalDamage;
                demonList.Add(currentDemon);

            }

            foreach (var demon in demonList)
            {
                
                Console.WriteLine($"{demon.Name} - {demon.Health} health, {demon.Damage:f2} damage");
            }

        }

        private static decimal CalculateDamage(MatchCollection matchesDamage, MatchCollection matchesMultiply, MatchCollection matchesDivide)
        {
            decimal totalDamage = 0;

            foreach (var damagePoint in matchesDamage)
            {
                decimal currentDamage = decimal.Parse(damagePoint.ToString());
                totalDamage += currentDamage;
            }
            if (totalDamage > 0)
            {
                foreach (var multiply in matchesMultiply)
                {
                    totalDamage *= 2;
                }
                foreach (var divide in matchesDivide)
                {
                    totalDamage /= 2;
                }
            }
            
            return totalDamage;

        }

        private static long CalculateHealth(MatchCollection matchesHealth)
        {
            long totalHealth = 0;

            foreach (Match healthMatch in matchesHealth)
            {
                char[] toChar = healthMatch.ToString().ToCharArray();
               

                foreach (var letter in toChar)
                {
                    long toInt = (long)letter;
                    totalHealth += toInt;
                }               
            }
            return totalHealth;
        }
    }
}
